using System.Diagnostics;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace gj.autofac.caching.redis.tester;

static class Program
{
    static void TimeAndRun(Action action)
    {
        var start = Stopwatch.StartNew();
        action.Invoke();
        start.Stop();
        Console.WriteLine(start.Elapsed.TotalMilliseconds);
    }
    static Task Main()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Base directory for appsettings.json
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

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
       
        services.AddSingleton<IConfiguration>(configuration);
        
        builder.Populate(services);

        builder.RegisterType<RedisConnectionManager>().SingleInstance();
        
        builder.RegisterType<RedisCacheInterceptor>();
        
        builder.RegisterType<ExampleService>()
            .As<IExampleService>()
            .EnableInterfaceInterceptors()
            .InterceptedBy(typeof(RedisCacheInterceptor));

        var container = builder.Build();
        var service = container.Resolve<IExampleService>();

        var id = 3;

        for (var i = 0; i < 5; i++)
        {
            TimeAndRun(async () => await service.AsyncFunctionTest(id));
        }
        for (var i = 0; i < 5; i++)
        {
            TimeAndRun(async () => await service.AsyncActionTest(50));
        }
        for (var i = 0; i < 5; i++)
        {
            TimeAndRun(() => service.SynchronousTaskTest());
        }

        return Task.CompletedTask;
    }
}