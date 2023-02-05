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
        Vec3<TNumber> first = new(right.X.X, right.Y.X, right.Z.X);
        Vec3<TNumber> second = new(right.X.Y, right.Y.Y, right.Z.Y);
        Vec3<TNumber> third = new(right.X.Z, right.Y.Z, right.Z.Z);

        return new(Vec3<TNumber>.Dot(left.X, first), Vec3<TNumber>.Dot(left.X, second), Vec3<TNumber>.Dot(left.X, third),
                   Vec3<TNumber>.Dot(left.Y, first), Vec3<TNumber>.Dot(left.Y, second), Vec3<TNumber>.Dot(left.Y, third),
                   Vec3<TNumber>.Dot(left.Z, first), Vec3<TNumber>.Dot(left.Z, second), Vec3<TNumber>.Dot(left.Z, third));
    }

    public static Vec3<TNumber> operator *(Mat3x3<TNumber> left, Vec3<TNumber> right)
        => new(Vec3<TNumber>.Dot(left.X, right), Vec3<TNumber>.Dot(left.Y, right), Vec3<TNumber>.Dot(left.Z, right));

    public static Mat3x3<TNumber> operator *(Mat3x3<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right, left.Z * right);

    public static Mat3x3<TNumber> operator /(Mat3x3<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right, left.Z / right);
    
    public static bool operator ==(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
        => left.Equals(right);

    public static bool operator !=(Mat3x3<TNumber> left, Mat3x3<TNumber> right)
        => !(left == right);
}