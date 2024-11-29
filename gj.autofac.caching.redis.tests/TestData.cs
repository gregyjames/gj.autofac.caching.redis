using System.Text.Json.Serialization;
using MessagePack;

namespace gj.autofac.caching.redis.tests;

[MessagePackObject(keyAsPropertyName: true)]
public class TestData
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public required string Title { get; set; }
    [JsonPropertyName("completed")]
    public bool Completed { get; set; }
}