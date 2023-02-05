using System.Runtime.CompilerServices;

namespace Rena.Mathematics;

// TODO: Simd on .NET 8
public partial struct Vec2<TNumber>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Vec2<TNumber> other)
        => X == other.X && Y == other.Y;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> MultiplyComponents(Vec2<TNumber> left, Vec2<TNumber> right)
        => new(left.X * right.X, left.Y * right.Y);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> DivideComponents(Vec2<TNumber> left, Vec2<TNumber> right)
        => new(left.X / right.X, left.Y / right.Y);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber Dot(Vec2<TNumber> left, Vec2<TNumber> right)
        => (left.X * right.X) + (left.Y * right.Y);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator +(Vec2<TNumber> left, Vec2<TNumber> right)
        => new(left.X + right.X, left.Y + right.Y);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator -(Vec2<TNumber> left, Vec2<TNumber> right)
        => new(left.X - right.X, left.Y - right.Y);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator *(Vec2<TNumber> left, TNumber right)
        => new(left.X * right, left.Y * right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator /(Vec2<TNumber> left, TNumber right)
        => new(left.X / right, left.Y / right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vec2<TNumber> left, Vec2<TNumber> right)
        => left.Equals(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vec2<TNumber> left, Vec2<TNumber> right)
        => !(left == right);
}