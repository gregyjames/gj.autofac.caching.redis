namespace gj.autofac.caching.redis.Serialization;

public interface IObjectSerializer
{
    public byte[] SerializeToBinary(object? obj);
    public object? DeserializeFromBinary(byte[] binaryData, Type type);
}