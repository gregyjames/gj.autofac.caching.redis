using gj.autofac.caching.redis;
using Microsoft.Extensions.Configuration;

namespace gj.autofac.caching.redis.tests;

[TestFixture]
[TestOf(typeof(RedisConfig))]
public class RedisConfigTest
{
    private IConfigurationRoot configuration;

    [SetUp]
    public void Setup()
    {
        var sampleJson = """
                         {
                           "Redis": {
                             "Host": "192.168.0.1",
                             "Port": 6379
                           }
                         }
                         """;
        var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(sampleJson));
        
        configuration = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();
    }
    
    [Test]
    public void BindIConfigurationToConfigTest()
    {
        var config = new RedisConfig();
        configuration.GetSection("Redis").Bind(config);
        Assert.That(config.Host, Is.Not.EqualTo("localhost"));
        Console.WriteLine($"Host: {config.Host}");
    }
}