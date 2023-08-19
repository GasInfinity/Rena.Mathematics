using System.Runtime.CompilerServices;
namespace Rena.Mathematics;

// TODO: Simd for Vec3!
public readonly partial struct Vec3<TNumber>
{
    public static explicit operator Vec2<TNumber>(Vec3<TNumber> self)
        => Unsafe.As<Vec3<TNumber>, Vec2<TNumber>>(ref self);

    public static explicit operator Vec3<TNumber>(Vec2<TNumber> self)
        => new(self, TNumber.Zero);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Vec3<TNumber> other)
        => X == other.X && Y == other.Y && Z == other.Z;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> MultiplyComponents(Vec3<TNumber> left, Vec3<TNumber> right)
        => new(left.X * right.X, left.Y * right.Y, left.Z * right.Z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> DivideComponents(Vec3<TNumber> left, Vec3<TNumber> right)
        => new(left.X / right.X, left.Y / right.Y, left.Z / right.Z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber Dot(Vec3<TNumber> left, Vec3<TNumber> right)
        => (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> Cross(Vec3<TNumber> left, Vec3<TNumber> right)
        => new((left.Y * right.Z) - (left.Z * right.Y), (left.Z * right.X) - (left.X * right.Z), (left.X * right.Y) - (left.Y * right.X));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> operator +(Vec3<TNumber> left, Vec3<TNumber> right)
        => new(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> operator -(Vec3<TNumber> left, Vec3<TNumber> right)
        => new(left.X - right.X, left.Y - right.Y, left.Z - right.Z);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> operator *(Vec3<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right, left.Z * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec3<TNumber> operator /(Vec3<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right, left.Z / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vec3<TNumber> left, Vec3<TNumber> right)
        => left.Equals(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vec3<TNumber> left, Vec3<TNumber> right)
        => !(left == right);
}