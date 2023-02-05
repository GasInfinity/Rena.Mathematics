using NUnit.Framework;

namespace Rena.Mathematics.Tests;

[TestFixture]
public class Mat4x4Tests
{
    private Mat4x4<float> matrixA;
    private Mat4x4<float> matrixB;

    [SetUp]
    public void SetUp()
    {
        matrixA = new Mat4x4<float>(
            1, 2, 3, 4,
            5, 6, 7, 8,
            9, 10, 11, 12,
            13, 14, 15, 16
        );

        matrixB = new Mat4x4<float>(
            17, 18, 19, 20,
            21, 22, 23, 24,
            25, 26, 27, 28,
            29, 30, 31, 32
        );
    }

    [Test]
    public void Addition_CorrectResult()
    {
        Mat4x4<float> result = matrixA + matrixB;
        Mat4x4<float> expected = new Mat4x4<float>(
            18, 20, 22, 24,
            26, 28, 30, 32,
            34, 36, 38, 40,
            42, 44, 46, 48
        );

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Subtraction_CorrectResult()
    {
        Mat4x4<float> result = matrixA - matrixB;
        Mat4x4<float> expected = new Mat4x4<float>(
            -16, -16, -16, -16,
            -16, -16, -16, -16,
            -16, -16, -16, -16,
            -16, -16, -16, -16
        );

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MultiplicationWithScalar_CorrectResult()
    {
        Mat4x4<float> result = matrixA * 2;
        Mat4x4<float> expected = new Mat4x4<float>(
            2, 4, 6, 8,
            10, 12, 14, 16,
            18, 20, 22, 24,
            26, 28, 30, 32
        );

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void DivisionWithScalar_CorrectResult()
    {
        Mat4x4<float> expected = new Mat4x4<float>(
            0.5f, 1, 1.5f, 2,
            2.5f, 3, 3.5f, 4,
            4.5f, 5, 5.5f, 6,
            6.5f, 7, 7.5f, 8
        );

        Mat4x4<float> result = matrixA / 2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MatrixMultiplication_CorrectResult()
    {
        Mat4x4<float> result = matrixA * matrixB;
        Mat4x4<float> expected = new Mat4x4<float>(
            250, 260, 270, 280,
            618, 644, 670, 696,
            986, 1028, 1070, 1112,
            1354, 1412, 1470, 1528
        );

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Vec4Multiplication_CorrectResult()
    {
        Vec4<float> vector = new Vec4<float>(1, 2, 3, 4);
        Vec4<float> result = matrixA * vector;
        Vec4<float> expected = new Vec4<float>(30, 70, 110, 150);

        Assert.AreEqual(expected, result);
    }
}