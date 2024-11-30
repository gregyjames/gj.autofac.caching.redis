using gj.autofac.caching.redis;
using gj.autofac.caching.redis.Serialization;

namespace gj.autofac.caching.redis.tests;

[TestFixture]
[TestOf(typeof(MessagePackObjectSerializer))]
public class JSONObjectSerializerTest
{
    private TestData _data;
    private JSONObjectSerializer _objectSerializer;

    [SetUp]
    public void Setup()
    {
        _data = new TestData()
        {
            Id = 8,
            UserId = 8,
            Title = "TEST",
            Completed = true
        };
        _objectSerializer = new JSONObjectSerializer();
    }

    [Test]
    public void SerializationTest()
    {
        var arr = _objectSerializer.SerializeToBinary(_data);
        Assert.That(arr, Is.Not.Empty);
    }
    
    [Test]
    public void DeserializationTest()
    {
        var arr = _objectSerializer.SerializeToBinary(_data);
        var data2 = (TestData)_objectSerializer.DeserializeFromBinary(arr, typeof(TestData))!;
        Assert.That(data2.Id, Is.EqualTo(8));
        Assert.That(data2.UserId, Is.EqualTo(8));
        Assert.That(data2.Title, Is.EqualTo("TEST"));
        Assert.That(data2.Completed, Is.True);
    }
}