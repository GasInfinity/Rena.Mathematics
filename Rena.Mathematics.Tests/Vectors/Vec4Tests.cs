namespace Rena.Mathematics.Tests;

[TestFixture]
public class Vec4Tests
{
    private Vec4<float> vectorA;
    private Vec4<float> vectorB;

    [SetUp]
    public void SetUp()
    {
        vectorA = new(1, 2, 3, 4);
        vectorB = new(5, 6, 7, 8);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Vec4<float> result = vectorA + vectorB;
        Vec4<float> expected = new(6, 8, 10, 12);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Vec4<float> result = vectorA - vectorB;
        Vec4<float> expected = new(-4, -4, -4, -4);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Dot_CorrectResult()
    {
        float result = Vec4<float>.Dot(vectorA, vectorB);
        const float expected = 70;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Vec4<float> result = vectorA * 2;
        Vec4<float> expected = new(2, 4, 6, 8);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Vec4<float> result = vectorA / 2;
        Vec4<float> expected = new(0.5f, 1, 1.5f, 2);

        Assert.AreEqual(expected, result);
    }
}