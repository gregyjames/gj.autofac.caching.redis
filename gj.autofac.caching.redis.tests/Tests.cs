using System.Diagnostics;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
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
    private IExampleService service;
    private ILogger<ExampleService> logger;

    [SetUp]
    public void Setup()
    {
        IConnectionMultiplexer _connection = new MockMultiplexer();
        _database = _connection.GetDatabase();
        
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
       
        //Either make sure IConfiguration or RedisConfig is registered.
        //services.AddSingleton<IConfiguration>(configuration);
        
        builder.Populate(services);
        
        //Register the Redis Connection as single instance
        builder.Register<IConnectionMultiplexer>(builder => new MockMultiplexer()).As<IConnectionMultiplexer>();
        
        builder.RegisterType<RedisConnectionManager>().SingleInstance();
        
        builder.RegisterType<RedisCacheInterceptor>();
        
        builder.RegisterType<ExampleService>()
            .As<IExampleService>()
            .EnableInterfaceInterceptors()
            .InterceptedBy(typeof(RedisCacheInterceptor));

        var container = builder.Build();
        
        service = container.Resolve<IExampleService>();
        logger = container.Resolve<ILogger<ExampleService>>();
        
        logger.LogInformation("Tests started...");
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
        
        Assert.IsTrue(_database.StringGet("TEST") == "VALUE");
    }

    [Test]
    public void AsyncFunctionTest()
    {
        var id = 877;

        try
        {
            for (int i = 0; i < 10; i++)
            {
                TimeAndRun(async () => await service.AsyncFunctionTest(id), logger);
            }
        }
        finally
        {
            Assert.IsTrue(_database.StringGet("Async").HasValue);
        }
    }
    
    [Test]
    public void AsyncActionTest()
    {
        var id = 607;
        
        for (int i = 0; i < 10; i++)
        {
            TimeAndRun(async () => await service.AsyncActionTest(id), logger);
        }
    }
    
    [Test]
    public void SyncFunctionTest()
    {
        var id = 550;

        try
        {
            for (int i = 0; i < 10; i++)
            {
                TimeAndRun(() => service.SynchronousTaskTest(), logger);
            }
        }
        finally
        {
            Assert.IsTrue(_database.StringGet("Sync").HasValue);
        }
    }

    [Test]
    public void KeyNotFoundTest()
    {
        var value = _database.StringGet("THIS_KEY_DOESNT_EXIST");
        Assert.IsFalse(value.HasValue);
    }
}