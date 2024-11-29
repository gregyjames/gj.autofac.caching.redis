using Microsoft.Extensions.Logging;

namespace gj.autofac.caching.redis.tests;

public interface IExampleService
{
    [RedisCache(120, "Async")]
    Task<bool> AsyncFunctionTest(int id);
    
    [RedisCache(120)]
    Task AsyncActionTest(int id);
    [RedisCache(120, "Sync")]
    bool SynchronousTaskTest();
    [RedisCache(180)]
    public Task<TestData> GetWeather(int number, ILogger logger);
}