using System.Runtime.Serialization.Formatters.Binary;

namespace gj.autofac.caching.redis.Serialization;

public class BinaryFormatterObjectSerializer: IObjectSerializer
{
    [Obsolete("Obsolete")]
    public byte[] SerializeToBinary(object? obj)
    {
        if (obj == null)
        {
            return [];
        }

        var bf = new BinaryFormatter();
        using var ms = new MemoryStream();
        bf.Serialize(ms, obj);
        return ms.ToArray();
    }

    [Obsolete("Obsolete")]
    public object? DeserializeFromBinary(byte[] binaryData, Type type)
    {
        if (binaryData.Length == 0)
        {
            return default;
        }

        BinaryFormatter bf = new BinaryFormatter();
        using MemoryStream ms = new MemoryStream(binaryData);
        return bf.Deserialize(ms);
    }
}