# autofac.caching.redis
Automatic function level caching using redis in C#.

## Usage
A full example can be found in the 	[gj.autofac.caching.redis.tester](https://github.com/gregyjames/gj.autofac.caching.redis/tree/main/gj.autofac.caching.redis.tester "gj.autofac.caching.redis.tester") directory.
```csharp
using System.Diagnostics;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RedisCache;
using Serilog;
using Serilog.Events;

namespace RedisCacheTester;

class Program
{
    static void TimeAndRun(Action action)
    {
        var start = Stopwatch.StartNew();
        action.Invoke();
        start.Stop();
        Console.WriteLine(start.Elapsed.TotalMilliseconds);
    }
    static async Task Main(string[] args)
    {
        RedisConnectionManager.Host = "192.168.0.47";
        RedisConnectionManager.Port = 6379;

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
        builder.RegisterType<RedisCacheInterceptor>();
        builder.RegisterType<ExampleService>()
            .As<IExampleService>()
            .EnableInterfaceInterceptors()
            .InterceptedBy(typeof(RedisCacheInterceptor));

        var container = builder.Build();
        var service = container.Resolve<IExampleService>();

        for (int i = 0; i < 5; i++)
        {
            TimeAndRun(async () => await service.AsyncFunctionTest(3));
        }
    }
}
```

## License
MIT License

Copyright (c) 2024 Greg James

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
