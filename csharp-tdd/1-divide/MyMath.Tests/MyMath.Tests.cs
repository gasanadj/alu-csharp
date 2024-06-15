using MyMath;
namespace MyMath.Tests;

[TestFixture]
public class Tests
{
    int[,] testMatrix = { { 10, 5 }, { 20, 10 } };
    [SetUp]
    public void Setup()
    {

    }

    [Test]

    public void Division_works_just_fine()
    {
        var result = Matrix.Divide(testMatrix, 5);
        int[,] expected = { { 2, 1 }, { 4, 2 } };
        Assert.That(expected, Is.EqualTo(result));
    }
    [Test]

    public void Division_By_Zero_Returns_Null()
    {
        var result = Matrix.Divide(testMatrix, 0);
        Assert.IsNull(result);
    }

    [Test]

    public void Check_for_null_matrices()
    {
        var result = Matrix.Divide(null, 3);
        Assert.IsNull(result);
    }
    [Test]

    public void Test_with_Empty_Matrix()
    {
        int[,] test = { { } };
        int[,] expected = { };
        var result = Matrix.Divide(test, 5);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]

    public void Test_with_a_Single_Element()
    {
        int[,] test = { { 10 } };
        int[,] expected = { { 5 } };
        var result = Matrix.Divide(test, 2);
        Assert.That(expected, Is.EqualTo(result));

    }

    [Test]

    public void Test_with_negatives_and_positives()
    {
        int[,] test = { { 10, -5 }, { -20, 10 }, { 40, -15 } };
        int[,] expected = { { 2, -1 }, { -4, 2 }, { 8, -3 } };
        var result = Matrix.Divide(test, 5);
        Assert.That(expected, Is.EqualTo(result));
    }
}