using MessagePack;

namespace gj.autofac.caching.redis;

public static class BinaryFormatterUtils
{
    /// <summary>
    /// Serializes an object to binary using MessagePack.
    /// </summary>
    /// <param name="obj">The object to serialize.</param>
    /// <returns>The binary representation of the object.</returns>
    public static byte[] SerializeToBinary(object obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        // Serialize the object using MessagePack
        return MessagePackSerializer.Serialize(obj);
    }

    /// <summary>
    /// Deserializes binary data to the specified type using MessagePack.
    /// </summary>
    /// <param name="binaryData">The binary data to deserialize.</param>
    /// <param name="type">The type to deserialize into.</param>
    /// <returns>The deserialized object.</returns>
    public static object DeserializeFromBinary(byte[] binaryData, Type type)
    {
        if (binaryData == null || binaryData.Length == 0)
        {
            throw new ArgumentException("Binary data cannot be null or empty.", nameof(binaryData));
        }

        if (type == null)
        {
            throw new ArgumentNullException(nameof(type));
        }

        // Deserialize the object using MessagePack
        return MessagePackSerializer.Deserialize(type, binaryData);
    }
}