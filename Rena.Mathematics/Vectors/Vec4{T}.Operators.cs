using System.Runtime.CompilerServices;

namespace Rena.Mathematics;

// TODO: Simd on .NET 8
public readonly partial struct Vec4<TNumber>
{
    public static explicit operator Vec2<TNumber>(Vec4<TNumber> self)
        => Unsafe.As<Vec4<TNumber>, Vec2<TNumber>>(ref self);

    public static explicit operator Vec4<TNumber>(Vec2<TNumber> self)
        => new(self, TNumber.Zero, TNumber.Zero);

    public static explicit operator Vec3<TNumber>(Vec4<TNumber> self)
        => Unsafe.As<Vec4<TNumber>, Vec3<TNumber>>(ref self);

    public static explicit operator Vec4<TNumber>(Vec3<TNumber> self)
        => new(self, TNumber.Zero);

    // TODO: Why does Unsafe.As use the stack with pointless mov's? :(
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Vec4<TNumber> other)
        => X == other.X && Y == other.Y && Z == other.Z && W == other.W;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> MultiplyComponents(Vec4<TNumber> left, Vec4<TNumber> right)
        => new(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> DivideComponents(Vec4<TNumber> left, Vec4<TNumber> right)
        => new(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber Dot(Vec4<TNumber> left, Vec4<TNumber> right)
        => (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator +(Vec4<TNumber> left, Vec4<TNumber> right)
        => new(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator -(Vec4<TNumber> left, Vec4<TNumber> right)
        => new(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator *(Vec4<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right, left.Z * right, left.W * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator /(Vec4<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right, left.Z / right, left.W / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vec4<TNumber> left, Vec4<TNumber> right)
        => left.Equals(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vec4<TNumber> left, Vec4<TNumber> right)
        => !(left == right);
}