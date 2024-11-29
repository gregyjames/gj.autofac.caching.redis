using gj.autofac.caching.redis;

namespace gj.autofac.caching.redis.tests;

[TestFixture]
[TestOf(typeof(BinaryFormatterUtils))]
public class BinaryFormatterUtilsTest
{
    private TestData _data;

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
    }

    [Test]
    public void SerializationTest()
    {
        var arr = BinaryFormatterUtils.SerializeToBinary(_data);
        Assert.That(arr, Is.Not.Empty);
    }
    
    [Test]
    public void DeserializationTest()
    {
        var arr = BinaryFormatterUtils.SerializeToBinary(_data);
        var data2 = (TestData)BinaryFormatterUtils.DeserializeFromBinary(arr, typeof(TestData))!;
        Assert.That(data2.Id, Is.EqualTo(8));
        Assert.That(data2.UserId, Is.EqualTo(8));
        Assert.That(data2.Title, Is.EqualTo("TEST"));
        Assert.That(data2.Completed, Is.True);
    }
}