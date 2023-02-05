using NUnit.Framework;

namespace Rena.Mathematics.Tests;

[TestFixture]
public class Vec2Tests
{
    private Vec2<float> vectorA;
    private Vec2<float> vectorB;

    [SetUp]
    public void SetUp()
    {
        vectorA = new Vec2<float>(3, 4);
        vectorB = new Vec2<float>(5, 6);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Vec2<float> result = vectorA + vectorB;
        Vec2<float> expected = new Vec2<float>(8, 10);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Vec2<float> result = vectorA - vectorB;
        Vec2<float> expected = new Vec2<float>(-2, -2);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Dot_CorrectResult()
    {
        float result = Vec2<float>.Dot(vectorA, vectorB);
        float expected = 39;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Vec2<float> result = vectorA * 5;
        Vec2<float> expected = new Vec2<float>(15, 20);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Vec2<float> result = vectorA / 2;
        Vec2<float> expected = new Vec2<float>(1.5f, 2);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MultiplyComponents_CorrectResult()
    {
        Vec2<float> result = Vec2<float>.MultiplyComponents(vectorA, vectorB);
        Vec2<float> expected = new Vec2<float>(15, 24);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void DivideComponents_CorrectResult()
    {
        Vec2<float> result = Vec2<float>.DivideComponents(vectorA, vectorB);
        Vec2<float> expected = new Vec2<float>(3/5f, 4/6f);

        Assert.AreEqual(expected, result);
    }
}