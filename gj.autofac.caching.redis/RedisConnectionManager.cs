using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace gj.autofac.caching.redis;

public class RedisConnectionManager
{
    public RedisConfig Config { get; set; } = new();
    public RedisConnectionManager(IConfiguration configuration)
    {
        _lazyConnection = new Lazy<IConnectionMultiplexer>(() =>
        {
            var connectionString = !string.IsNullOrEmpty(Config.Password) ? $"{Config.Host}:{Config.Port},password={Config.Password}" : $"{Config.Host}:{Config.Port}";
            return ConnectionMultiplexer.Connect(connectionString);
        });
        configuration.GetSection("Redis").Bind(Config);
    }

    public RedisConnectionManager(RedisConfig config)
    {
        Config = config;
        _lazyConnection = new Lazy<IConnectionMultiplexer>(() =>
        {
            var connectionString = !string.IsNullOrEmpty(Config.Password) ? $"{Config.Host}:{Config.Port},password={Config.Password}" : $"{Config.Host}:{Config.Port}";
            return ConnectionMultiplexer.Connect(connectionString);
        });
    }

    public RedisConnectionManager(IConnectionMultiplexer connectionMultiplexer)
    {
        _lazyConnection = new Lazy<IConnectionMultiplexer>(() => connectionMultiplexer);
    }
    
    private readonly Lazy<IConnectionMultiplexer> _lazyConnection;

    public IConnectionMultiplexer Connection => _lazyConnection.Value;
    
    public IDatabase Database => _lazyConnection.Value.GetDatabase(Config.DataBaseId);
}