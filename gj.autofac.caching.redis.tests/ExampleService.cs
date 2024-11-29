using System.Net.Http.Json;
using Microsoft.Extensions.Logging;

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
    
    public async Task<TestData> GetWeather(int number, ILogger logger)
    {
        await Task.Delay(5000);
        logger.LogInformation("Getting data for {0}", number);
        var url = $"https://jsonplaceholder.typicode.com/todos/{number}";
        using var client = new HttpClient();
        var obj = await client.GetFromJsonAsync<TestData>(url);
        return obj;
    }

    public string ExpiryTest()
    {
        return "VALUE";
    }
}