namespace gj.autofac.caching.redis.tester;

public interface IExampleService
{
    [RedisCache(120)]
    Task<int[]> AsyncFunctionTest(int id);
    
    [RedisCache(120)]
    Task AsyncActionTest(int id);
    [RedisCache(120)]
    int SynchronousTaskTest();
}
