namespace Rena.Mathematics;

public readonly partial struct Mat4x4<TNumber>
{
    public bool Equals(Mat4x4<TNumber> other)
        => X == other.X && Y == other.Y && Z == other.Z && W == other.W;

    public static Mat4x4<TNumber> operator +(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
        => new(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);

    public static Mat4x4<TNumber> operator -(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
        => new(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);

    public static Mat4x4<TNumber> operator *(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
    {
        Mat4x4<TNumber> transposedRight = right.Transpose();

        return new(Vec4<TNumber>.Dot(left.X, transposedRight.X), Vec4<TNumber>.Dot(left.X, transposedRight.Y), Vec4<TNumber>.Dot(left.X, transposedRight.Z), Vec4<TNumber>.Dot(left.X, transposedRight.W),
                   Vec4<TNumber>.Dot(left.Y, transposedRight.X), Vec4<TNumber>.Dot(left.Y, transposedRight.Y), Vec4<TNumber>.Dot(left.Y, transposedRight.Z), Vec4<TNumber>.Dot(left.Y, transposedRight.W),
                   Vec4<TNumber>.Dot(left.Z, transposedRight.X), Vec4<TNumber>.Dot(left.Z, transposedRight.Y), Vec4<TNumber>.Dot(left.Z, transposedRight.Z), Vec4<TNumber>.Dot(left.Z, transposedRight.W),
                   Vec4<TNumber>.Dot(left.W, transposedRight.X), Vec4<TNumber>.Dot(left.W, transposedRight.Y), Vec4<TNumber>.Dot(left.W, transposedRight.Z), Vec4<TNumber>.Dot(left.W, transposedRight.W));
    }

    public static Vec4<TNumber> operator *(Vec4<TNumber> left, Mat4x4<TNumber> right)
        => new(Vec4<TNumber>.Dot(left, right.X), Vec4<TNumber>.Dot(left, right.Y), Vec4<TNumber>.Dot(left, right.Z), Vec4<TNumber>.Dot(left, right.W));

    public static Mat4x4<TNumber> operator *(Mat4x4<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right, left.Z * right, left.W * right);

    public static Mat4x4<TNumber> operator /(Mat4x4<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right, left.Z / right, left.W / right);

    public static bool operator ==(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
        => left.Equals(right);

    public static bool operator !=(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
        => !(left == right);
}