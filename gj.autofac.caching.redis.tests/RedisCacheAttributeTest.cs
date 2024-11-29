using System.Reflection;
using gj.autofac.caching.redis;

namespace gj.autofac.caching.redis.tests;

[TestFixture]
[TestOf(typeof(RedisCacheAttribute))]
public class RedisCacheAttributeTest
{
    private MethodInfo? _methodInfo;

    [SetUp]
    public void Setup()
    {
        var functionName = nameof(IExampleService.SynchronousTaskTest);
        Console.WriteLine($"Getting methodInfo for {functionName}...");
        _methodInfo = typeof(IExampleService).GetMethod(functionName);
    }
    

    [Test]
    public void TestAttribute()
    {
        if (_methodInfo == null)
        {
            Console.WriteLine("Method not found.");
            Assert.Fail();
        }

        Assert.That(_methodInfo?.GetCustomAttributes(typeof(RedisCacheAttribute)), Is.Not.Null);
        Console.WriteLine("TEST PASSED");
    }

    [Test]
    public void TestAttributeProperties()
    {
        var attribute = _methodInfo?.GetCustomAttributes(typeof(RedisCacheAttribute)).First() as RedisCacheAttribute;
        Assert.That(attribute.DurationSeconds == 120, Is.True);
        Console.WriteLine("TEST PASSED");
    }
}