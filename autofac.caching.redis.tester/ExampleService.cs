using System.Threading.Tasks;
using RedisCache;
using RedisCacheTester;

public class ExampleService : IExampleService
{
    
    [RedisCache(60)]
    public async Task<int[]> AsyncFunctionTest(int id)
    {
        await Task.Delay(5000);
        //return $"Data for ID {id}";
        return Enumerable.Range(0, id).ToArray();
    }

    [RedisCache(60)]
    public async Task AsyncActionTest(int id)
    {
        await Task.Delay(5000);
        Console.WriteLine("Doing something....");
    }

    [RedisCache(60)]
    public int SynchronousTaskTest()
    {
        return 30;
    }
}