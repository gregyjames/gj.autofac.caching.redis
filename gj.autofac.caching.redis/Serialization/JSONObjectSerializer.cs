using System.Text;
using Newtonsoft.Json;

namespace gj.autofac.caching.redis.Serialization;

public class JSONObjectSerializer: IObjectSerializer
{
    /// <summary>
    /// Serializes an object to binary using JSON.
    /// </summary>
    /// <param name="obj">The object to serialize.</param>
    /// <returns>The binary representation of the object.</returns>
    public byte[] SerializeToBinary(object? obj)
    {
        return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(obj));
    }

    /// <summary>
    /// Deserializes binary data to the specified type using JSON.
    /// </summary>
    /// <param name="binaryData">The binary data to deserialize.</param>
    /// <param name="type">The type to deserialize into.</param>
    /// <returns>The deserialized object.</returns>
    public object? DeserializeFromBinary(byte[] binaryData, Type type)
    {
        string resultString = Encoding.UTF8.GetString(binaryData);
        return JsonConvert.DeserializeObject(resultString, type);
    }
}