namespace gj.autofac.caching.redis.tests;

public class ExampleService : IExampleService
{
    public async Task<bool> AsyncFunctionTest(int id)
    {
        await Task.Delay(5000);
        return true;
    }
    
    public async Task AsyncActionTest(int id)
    {
        await Task.Delay(5000);
    }
    
    public bool SynchronousTaskTest()
    {
        Thread.Sleep(5000);
        return true;
    }
}