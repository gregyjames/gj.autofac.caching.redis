using StackExchange.Redis;

namespace RedisCache;

public static class RedisConnectionManager
{
    public static int DataBaseId { get; set; }= -1;
    public static int Port { get; set; } = 6379;
    public static string? Password { get; set; }
    public static string Host { get; set; } = "localhost";
    private static readonly Lazy<ConnectionMultiplexer> LazyConnection = new(() =>
    {
        var connectionString = !string.IsNullOrEmpty(Password) ? $"{Host}:{Port},password={Password}" : $"{Host}:{Port}";
        return ConnectionMultiplexer.Connect(connectionString);
    });

    public static ConnectionMultiplexer Connection => LazyConnection.Value;
    
    public static IDatabase Database => LazyConnection.Value.GetDatabase(DataBaseId);
}