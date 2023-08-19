namespace Rena.Mathematics.Tests;

[TestFixture]
public class Vec2Tests
{
    private Vec2<float> vectorA;
    private Vec2<float> vectorB;

    [SetUp]
    public void SetUp()
    {
        vectorA = new(3, 4);
        vectorB = new(5, 6);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Vec2<float> result = vectorA + vectorB;
        Vec2<float> expected = new(8, 10);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Vec2<float> result = vectorA - vectorB;
        Vec2<float> expected = new(-2, -2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Dot_CorrectResult()
    {
        float result = Vec2<float>.Dot(vectorA, vectorB);
        const float expected = 39;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Vec2<float> result = vectorA * 5;
        Vec2<float> expected = new(15, 20);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Vec2<float> result = vectorA / 2;
        Vec2<float> expected = new(1.5f, 2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplyComponents_CorrectResult()
    {
        Vec2<float> result = Vec2<float>.MultiplyComponents(vectorA, vectorB);
        Vec2<float> expected = new(15, 24);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void DivideComponents_CorrectResult()
    {
        Vec2<float> result = Vec2<float>.DivideComponents(vectorA, vectorB);
        Vec2<float> expected = new(3 / 5f, 4 / 6f);

        Assert.That(result, Is.EqualTo(expected));
    }
}