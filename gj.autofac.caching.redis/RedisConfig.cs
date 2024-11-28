namespace gj.autofac.caching.redis;

public class RedisConfig
{
    public int DataBaseId { get; set; }= -1;
    public int Port { get; set; } = 6379;
    public string? Password { get; set; }
    public string Host { get; set; } = "localhost";
}