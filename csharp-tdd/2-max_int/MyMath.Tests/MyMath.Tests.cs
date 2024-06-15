using System.Runtime.CompilerServices;
using MyMath;
namespace MyMath.Tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]

    public void Test_with_positive_numbers() {
        List<int> nums = new List<int> {1,2,4,5};
        var result = Operations.Max(nums);
        var expected = 5;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_with_negative_numbers() {
        List<int> nums = new List<int> {-1,-2,-4,-5};
        var result = Operations.Max(nums);
        var expected = -1;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_with_negative_and_postive_numbers() {
        List<int> nums = new List<int> {-1,-2,4,-5};
        var result = Operations.Max(nums);
        var expected = 4;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_with_Single_Element() {
        List<int> nums = new List<int> {-5};
        var result = Operations.Max(nums);
        var expected = -5;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]

    public void Test_with_empty_list() {
        List<int> nums = new List<int>();
        var result = Operations.Max(nums);
        var expected = 0;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]

    public void Test_With_Large_Numbers() {
        List<int>nums = new List<int>{int.MinValue, int.MaxValue, 0};
        var expected = int.MaxValue;
        var result = Operations.Max(nums);
        Assert.That(expected, Is.EqualTo(result));
    }
}