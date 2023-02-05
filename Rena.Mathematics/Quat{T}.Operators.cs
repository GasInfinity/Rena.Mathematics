using System.Runtime.CompilerServices;

namespace Rena.Mathematics;

// TODO: Simd on .NET 8
public partial struct Quat<TNumber>
{
    public static TNumber Dot(Quat<TNumber> left, Quat<TNumber> right)
        => (left.W * right.W) + (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);

    public static Quat<TNumber> operator *(Quat<TNumber> left, TNumber right)
        => new(left.W * right, left.X * right, left.Y * right, left.Z * right);

    public static Quat<TNumber> operator /(Quat<TNumber> left, TNumber right)
        => new(left.W * right, left.X * right, left.Y * right, left.Z * right);
}