namespace Rena.Mathematics.Tests;

[TestFixture]
public class Vec3Tests
{
    private Vec3<float> vectorA;
    private Vec3<float> vectorB;

    [SetUp]
    public void SetUp()
    {
        vectorA = new(3, 4, 5);
        vectorB = new(5, 6, 7);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Vec3<float> result = vectorA + vectorB;
        Vec3<float> expected = new(8, 10, 12);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Vec3<float> result = vectorA - vectorB;
        Vec3<float> expected = new(-2, -2, -2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Dot_CorrectResult()
    {
        float result = Vec3<float>.Dot(vectorA, vectorB);
        const float expected = 74;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CrossProduct_CorrectResult()
    {
        Vec3<float> result = Vec3<float>.Cross(vectorA, vectorB);
        Vec3<float> expected = new(-2, 4, -2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Vec3<float> result = vectorA * 5;
        Vec3<float> expected = new(15, 20, 25);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Vec3<float> result = vectorA / 2;
        Vec3<float> expected = new(1.5f, 2, 2.5f);

        Assert.That(result, Is.EqualTo(expected));
    }
}