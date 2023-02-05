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
        Vec4<TNumber> first = new(right.X.X, right.Y.X, right.Z.X, right.W.X);
        Vec4<TNumber> second = new(right.X.Y, right.Y.Y, right.Z.Y, right.W.Y);
        Vec4<TNumber> third = new(right.X.Z, right.Y.Z, right.Z.Z, right.W.Z);
        Vec4<TNumber> fourth = new(right.X.W, right.Y.W, right.Z.W, right.W.W);

        return new(Vec4<TNumber>.Dot(left.X, first), Vec4<TNumber>.Dot(left.X, second), Vec4<TNumber>.Dot(left.X, third), Vec4<TNumber>.Dot(left.X, fourth),
                   Vec4<TNumber>.Dot(left.Y, first), Vec4<TNumber>.Dot(left.Y, second), Vec4<TNumber>.Dot(left.Y, third), Vec4<TNumber>.Dot(left.Y, fourth),
                   Vec4<TNumber>.Dot(left.Z, first), Vec4<TNumber>.Dot(left.Z, second), Vec4<TNumber>.Dot(left.Z, third), Vec4<TNumber>.Dot(left.Z, fourth),
                   Vec4<TNumber>.Dot(left.W, first), Vec4<TNumber>.Dot(left.W, second), Vec4<TNumber>.Dot(left.W, third), Vec4<TNumber>.Dot(left.W, fourth));
    }

    public static Vec4<TNumber> operator *(Mat4x4<TNumber> left, Vec4<TNumber> right)
        => new(Vec4<TNumber>.Dot(left.X, right), Vec4<TNumber>.Dot(left.Y, right), Vec4<TNumber>.Dot(left.Z, right), Vec4<TNumber>.Dot(left.W, right));

    public static Mat4x4<TNumber> operator *(Mat4x4<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right, left.Z * right, left.W * right);

    public static Mat4x4<TNumber> operator /(Mat4x4<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right, left.Z / right, left.W / right);

    public static bool operator ==(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
        => left.Equals(right);

    public static bool operator !=(Mat4x4<TNumber> left, Mat4x4<TNumber> right)
        => !(left == right);
}