namespace Rena.Mathematics.Tests;

[TestFixture]
public class Mat3x3Tests
{
    private Mat3x3<float> matrix1;
    private Mat3x3<float> matrix2;

    [SetUp]
    public void SetUp()
    {
        matrix1 = new(1, 2, 3, 4, 5, 6, 7, 8, 9);
        matrix2 = new(9, 8, 7, 6, 5, 4, 3, 2, 1);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Mat3x3<float> expected = new(10, 10, 10, 10, 10, 10, 10, 10, 10);

        Mat3x3<float> result = matrix1 + matrix2;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Mat3x3<float> expected = new(-8, -6, -4, -2, 0, 2, 4, 6, 8);

        Mat3x3<float> result = matrix1 - matrix2;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Mat3x3<float> expected = new(2, 4, 6, 8, 10, 12, 14, 16, 18);

        Mat3x3<float> result = matrix1 * 2;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Mat3x3<float> expected = new(0.5f, 1, 1.5f, 2, 2.5f, 3, 3.5f, 4, 4.5f);

        Mat3x3<float> result = matrix1 / 2;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MatrixMultiplication_CorrectResult()
    {
        Mat3x3<float> expected = new(30, 24, 18, 84, 69, 54, 138, 114, 90);

        Mat3x3<float> result = matrix1 * matrix2;

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Vec3Multiplication_CorrectResult()
    {
        Vec3<float> vector = new(1, 2, 3);
        Vec3<float> expected = new(14, 32, 50);

        Vec3<float> result = matrix1 * vector;

        Assert.That(result, Is.EqualTo(expected));
    }
}