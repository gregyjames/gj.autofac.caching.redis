using Castle.Core.Configuration;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace gj.autofac.caching.redis;

public class RedisConnectionManager
{
    public RedisConfig Config { get; set; } = new();
    public RedisConnectionManager(Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        LazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            var connectionString = !string.IsNullOrEmpty(Config.Password) ? $"{Config.Host}:{Config.Port},password={Config.Password}" : $"{Config.Host}:{Config.Port}";
            return ConnectionMultiplexer.Connect(connectionString);
        });
        configuration.GetSection("Redis").Bind(Config);
    }
    
    private readonly Lazy<ConnectionMultiplexer> LazyConnection;

    public ConnectionMultiplexer Connection => LazyConnection.Value;
    
    public IDatabase Database => LazyConnection.Value.GetDatabase(Config.DataBaseId);
}