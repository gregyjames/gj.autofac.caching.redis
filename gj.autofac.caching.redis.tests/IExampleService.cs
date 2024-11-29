namespace gj.autofac.caching.redis.tests;

public interface IExampleService
{
    [RedisCache(120, "Async")]
    Task<bool> AsyncFunctionTest(int id);
    
    [RedisCache(120)]
    Task AsyncActionTest(int id);
    [RedisCache(120, "Sync")]
    bool SynchronousTaskTest();
}