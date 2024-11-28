namespace gj.autofac.caching.redis;

[AttributeUsage(AttributeTargets.Method)]
public class RedisCacheAttribute(int durationSeconds = 60, string key = "") : Attribute
{
    public int DurationSeconds { get; } = durationSeconds;
    public string Key { get; set; } = key;
}