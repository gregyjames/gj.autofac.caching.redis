namespace gj.autofac.caching.redis.tester;

public class ExampleService : IExampleService
{
    public async Task<string> AsyncFunctionTest(int id)
    {
        await Task.Delay(5000);
        return string.Join(',',Enumerable.Range(0, id));
    }
    
    public async Task AsyncActionTest(int id)
    {
        await Task.Delay(5000);
    }
    
    public int SynchronousTaskTest()
    {
        Thread.Sleep(5000);
        return 30;
    }
}