namespace gj.autofac.caching.redis;

[AttributeUsage(AttributeTargets.Method)]
public class RedisCacheAttribute(int durationSeconds = 60) : Attribute
{
    public int DurationSeconds { get; } = durationSeconds;
}