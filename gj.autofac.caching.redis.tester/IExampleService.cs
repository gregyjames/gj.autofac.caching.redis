using RedisCache;

namespace RedisCacheTester;

using System.Threading.Tasks;

public interface IExampleService
{
    [RedisCache(60)]
    Task<int[]> AsyncFunctionTest(int id);
    
    [RedisCache(60)]
    Task AsyncActionTest(int id);
    [RedisCache(60)]
    int SynchronousTaskTest();
    
}
