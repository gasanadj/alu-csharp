namespace MyMath.Tests;

[TestFixture]
public class Tests
{
    private Operations _operations;
    [SetUp]
    public void Setup()
    {
        _operations = new Operations();

    }

    [Test]
    public void Addition_of_two_positive_numbers_should_work()
    {
        var result = _operations.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]

    public void Addition_of_two_negative_numbers_should_work()
    {
        var result = _operations.Add(2, -1);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]

    public void Addition_of_a_posive_number_and_a_negative_number_should_work()
    {
        var result = _operations.Add(-1, -1);
        Assert.That(result, Is.EqualTo(-2));
    }
    [Test]
    public void Check_identity_element_for_addition() {
        var result = _operations.Add(0,1);
        Assert.That(result, Is.EqualTo(1));
    }
}