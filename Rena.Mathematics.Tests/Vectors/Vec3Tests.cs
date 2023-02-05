using NUnit.Framework;

namespace Rena.Mathematics.Tests;

[TestFixture]
public class Vec3Tests
{
    private Vec3<float> vectorA;
    private Vec3<float> vectorB;

    [SetUp]
    public void SetUp()
    {
        vectorA = new Vec3<float>(3, 4, 5);
        vectorB = new Vec3<float>(5, 6, 7);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Vec3<float> result = vectorA + vectorB;
        Vec3<float> expected = new Vec3<float>(8, 10, 12);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Vec3<float> result = vectorA - vectorB;
        Vec3<float> expected = new Vec3<float>(-2, -2, -2);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Dot_CorrectResult()
    {
        float result = Vec3<float>.Dot(vectorA, vectorB);
        float expected = 74;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void CrossProduct_CorrectResult()
    {
        Vec3<float> result = Vec3<float>.Cross(vectorA, vectorB);
        Vec3<float> expected = new Vec3<float>(-2, 4, -2);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Vec3<float> result = vectorA * 5;
        Vec3<float> expected = new Vec3<float>(15, 20, 25);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Vec3<float> result = vectorA / 2;
        Vec3<float> expected = new Vec3<float>(1.5f, 2, 2.5f);

        Assert.AreEqual(expected, result);
    }
}