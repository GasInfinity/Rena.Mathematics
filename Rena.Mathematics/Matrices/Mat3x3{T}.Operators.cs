namespace Rena.Mathematics;

public readonly partial struct Mat3x3<TNumber>
{
    public bool Equals(Mat3x3<TNumber> other)
        => X == other.X && Y == other.Y && Z == other.Z;

    public static Mat3x3<TNumber> operator +(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
        => new(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

    public static Mat3x3<TNumber> operator -(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
        => new(left.X - right.X, left.Y - right.Y, left.Z - right.Z);

    public static Mat3x3<TNumber> operator *(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
    {
        Mat3x3<TNumber> rightTransposed = right.Transpose();

        return new(Vec3<TNumber>.Dot(left.X, rightTransposed.X), Vec3<TNumber>.Dot(left.X, rightTransposed.Y), Vec3<TNumber>.Dot(left.X, rightTransposed.Z),
                   Vec3<TNumber>.Dot(left.Y, rightTransposed.X), Vec3<TNumber>.Dot(left.Y, rightTransposed.Y), Vec3<TNumber>.Dot(left.Y, rightTransposed.Z),
                   Vec3<TNumber>.Dot(left.Z, rightTransposed.X), Vec3<TNumber>.Dot(left.Z, rightTransposed.Y), Vec3<TNumber>.Dot(left.Z, rightTransposed.Z));
    }

    public static Vec3<TNumber> operator *(Vec3<TNumber> left, Mat3x3<TNumber> right)
        => new(Vec3<TNumber>.Dot(left, right.X), Vec3<TNumber>.Dot(left, right.Y), Vec3<TNumber>.Dot(left, right.Z));

    public static Mat3x3<TNumber> operator *(Mat3x3<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right, left.Z * right);

    public static Mat3x3<TNumber> operator /(Mat3x3<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right, left.Z / right);

    public static bool operator ==(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
        => left.Equals(right);

    public static bool operator !=(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
        => !(left == right);
}