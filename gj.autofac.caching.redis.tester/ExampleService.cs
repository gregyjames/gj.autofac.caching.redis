namespace gj.autofac.caching.redis.tester;

public class ExampleService : IExampleService
{
    public async Task<int[]> AsyncFunctionTest(int id)
    {
        await Task.Delay(5000);
        return Enumerable.Range(0, id).ToArray();
    }
    
    public async Task AsyncActionTest(int id)
    {
        await Task.Delay(5000);
        Console.WriteLine("Doing something....");
    }
    
    public int SynchronousTaskTest()
    {
        Thread.Sleep(5000);
        return 30;
    }
}