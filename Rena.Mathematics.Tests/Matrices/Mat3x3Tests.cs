using NUnit.Framework;

namespace Rena.Mathematics.Tests;

[TestFixture]
public class Mat3x3Tests
{
    private Mat3x3<float> matrix1;
    private Mat3x3<float> matrix2;

    [SetUp]
    public void SetUp()
    {
        matrix1 = new Mat3x3<float>(1, 2, 3, 4, 5, 6, 7, 8, 9);
        matrix2 = new Mat3x3<float>(9, 8, 7, 6, 5, 4, 3, 2, 1);
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Mat3x3<float> expected = new Mat3x3<float>(10, 10, 10, 10, 10, 10, 10, 10, 10);

        Mat3x3<float> result = matrix1 + matrix2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Mat3x3<float> expected = new Mat3x3<float>(-8, -6, -4, -2, 0, 2, 4, 6, 8);

        Mat3x3<float> result = matrix1 - matrix2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Mat3x3<float> expected = new Mat3x3<float>(2, 4, 6, 8, 10, 12, 14, 16, 18);

        Mat3x3<float> result = matrix1 * 2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Mat3x3<float> expected = new Mat3x3<float>(0.5f, 1, 1.5f, 2, 2.5f, 3, 3.5f, 4, 4.5f);

        Mat3x3<float> result = matrix1 / 2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MatrixMultiplication_CorrectResult()
    {
        Mat3x3<float> expected = new Mat3x3<float>(30, 24, 18, 84, 69, 54, 138, 114, 90);

        Mat3x3<float> result = matrix1 * matrix2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Vec3Multiplication_CorrectResult()
    {
        Vec3<float> vector = new Vec3<float>(1, 2, 3);
        Vec3<float> expected = new Vec3<float>(14, 32, 50);

        Vec3<float> result = matrix1 * vector;

        Assert.AreEqual(expected, result);
    }
}