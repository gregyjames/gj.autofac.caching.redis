using System.Diagnostics;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using gj.autofac.caching.redis.Serialization;
using gj.autofac.caching.redis.tests.MockObjects;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using StackExchange.Redis;

namespace gj.autofac.caching.redis.tests;

public class Tests
{
    private IDatabase _database;
    private IExampleService _service;
    private ILogger<ExampleService> _logger;
    
    private const int LoopCount = 15;
    
    [SetUp]
    public void Setup()
    {
        IConnectionMultiplexer connection = new MockMultiplexer();
        _database = connection.GetDatabase();
        
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Verbose)
            .CreateLogger();
       
        var services = new ServiceCollection();
        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddSerilog(dispose: false);
        });
        
        var builder = new ContainerBuilder();
        
        builder.Populate(services);
        
        //Register the Redis Connection as single instance
        builder.Register<IConnectionMultiplexer>(_ => new MockMultiplexer()).As<IConnectionMultiplexer>();

        builder.RegisterType<MessagePackObjectSerializer>().As<IObjectSerializer>();
        
        builder.RegisterType<RedisConnectionManager>().SingleInstance();
        
        builder.RegisterType<RedisCacheInterceptor>();
        
        builder.RegisterType<ExampleService>()
            .As<IExampleService>()
            .EnableInterfaceInterceptors()
            .InterceptedBy(typeof(RedisCacheInterceptor));

        var container = builder.Build();
        
        _service = container.Resolve<IExampleService>();
        _logger = container.Resolve<ILogger<ExampleService>>();
        
        _logger.LogInformation("Tests started...");
    }

    static void TimeAndRun(Action action, Microsoft.Extensions.Logging.ILogger logger)
    {
        var start = Stopwatch.StartNew();
        action.Invoke();
        start.Stop();
        logger.LogInformation("Time taken: {0}ms", start.Elapsed.TotalMilliseconds);
    }
    
    [Test]
    public void RedisGetSetTest()
    {
        _database.StringSet("TEST", "VALUE");
        
        Assert.That(_database.StringGet("TEST") == "VALUE", Is.True);
    }

    [Test]
    public void AsyncFunctionTest()
    {
        var id = 877;

        try
        {
            for (int i = 0; i < LoopCount; i++)
            {
                TimeAndRun(async () => await _service.AsyncFunctionTest(id), _logger);
            }
        }
        finally
        {
            Assert.That(_database.StringGet("Async").HasValue, Is.True);
        }
    }
    
    [Test]
    public void AsyncActionTest()
    {
        var id = 607;
        
        for (int i = 0; i < LoopCount; i++)
        {
            TimeAndRun(async () => await _service.AsyncActionTest(id), _logger);
        }
    }
    
    [Test]
    public void SyncFunctionTest()
    {
        try
        {
            for (int i = 0; i < LoopCount; i++)
            {
                TimeAndRun(() => _service.SynchronousTaskTest(), _logger);
            }
        }
        finally
        {
            Assert.That(_database.StringGet("Sync").HasValue, Is.True);
        }
    }

    [Test]
    public void KeyNotFoundTest()
    {
        var value = _database.StringGet("THIS_KEY_DOESNT_EXIST");
        Assert.That(value.HasValue, Is.False);
    }

    [Test]
    public async Task TaskObjectReturnTest()
    {
        for (var i = 1; i < LoopCount; i++)
        {
            var item = await _service.GetWeather(8, _logger);
            Assert.That(item, Is.Not.Null);
            _logger.LogInformation("{0} - {1} done.", i, item.Title);
        }
    }
    
    [Test]
    public void AttributeExpiredTest()
    {
        _service.ExpiryTest();
        Thread.Sleep(3500);
        var value = _database.StringGet("Expiery");
        Assert.That(value.HasValue, Is.False);
    }
}