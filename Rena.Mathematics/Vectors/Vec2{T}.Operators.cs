using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Rena.Mathematics;

[SkipLocalsInit]
public unsafe partial struct Vec2<TNumber>
{
    // We can't use Vector256 SIMD here, the max size for a vec2 here for SIMD is 16 bytes = 128 bits
    
    #pragma warning disable CS8500 // This takes the size of a managed type... (Ok? Thats what I want)
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Vec2<TNumber> other)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return Unsafe.BitCast<Vec2<TNumber>, Vector128<TNumber>>(this) == Unsafe.BitCast<Vec2<TNumber>, Vector128<TNumber>>(other);
        
        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return this.AsLowerVector128Unsafe() == other.AsLowerVector128Unsafe();

            return this.AsVector64Unsafe() == other.AsVector64Unsafe();
        }

        return X == other.X && Y == other.Y;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> MultiplyComponents(Vec2<TNumber> left, Vec2<TNumber> right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec2Unsafe(left.AsVector128Unsafe() * right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec2LowerUnsafe(left.AsLowerVector128Unsafe() * right.AsLowerVector128Unsafe());

            return AsVec2Unsafe(left.AsVector64Unsafe() * right.AsVector64Unsafe());
        }

        return new(left.X * right.X, left.Y * right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> DivideComponents(Vec2<TNumber> left, Vec2<TNumber> right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec2Unsafe(left.AsVector128Unsafe() / right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec2LowerUnsafe(left.AsLowerVector128Unsafe() / right.AsLowerVector128Unsafe());

            return AsVec2Unsafe(left.AsVector64Unsafe() / right.AsVector64Unsafe());
        }

        return new(left.X / right.X, left.Y / right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber Dot(Vec2<TNumber> left, Vec2<TNumber> right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return Vector128.Dot(left.AsVector128Unsafe(), right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return Vector128.Dot(left.AsLowerVector128Unsafe(), right.AsLowerVector128Unsafe());

            return Vector64.Dot(left.AsVector64Unsafe(), right.AsVector64Unsafe());
        }

        return (left.X * right.X) + (left.Y * right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator +(Vec2<TNumber> left, Vec2<TNumber> right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec2Unsafe(left.AsVector128Unsafe() + right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec2LowerUnsafe(left.AsLowerVector128Unsafe() + right.AsLowerVector128Unsafe());

            return AsVec2Unsafe(left.AsVector64Unsafe() + right.AsVector64Unsafe());
        }

        return new(left.X + right.X, left.Y + right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator -(Vec2<TNumber> left, Vec2<TNumber> right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec2Unsafe(left.AsVector128Unsafe() - right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec2LowerUnsafe(left.AsLowerVector128Unsafe() - right.AsLowerVector128Unsafe());

            return AsVec2Unsafe(left.AsVector64Unsafe() - right.AsVector64Unsafe());
        }

        return new(left.X - right.X, left.Y - right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator *(Vec2<TNumber> left, TNumber right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
        {
            return AsVec2Unsafe(left.AsVector128Unsafe() * Vector128.Create(right));
        }

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec2LowerUnsafe(left.AsLowerVector128Unsafe() * Vector128.Create(right));

            return AsVec2Unsafe(left.AsVector64Unsafe() * Vector64.Create(right));
        }

        return new(left.X * right, left.Y * right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec2<TNumber> operator /(Vec2<TNumber> left, TNumber right)
    {
        if (sizeof(Vector128<TNumber>) == sizeof(Vec2<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec2Unsafe(left.AsVector128Unsafe() / Vector128.Create(right));

        if (sizeof(Vector64<TNumber>) == sizeof(Vec2<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec2LowerUnsafe(left.AsLowerVector128Unsafe() / Vector128.Create(right));

            return AsVec2Unsafe(left.AsVector64Unsafe() / Vector64.Create(right));
        }

        return new(left.X / right, left.Y / right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vec2<TNumber> left, Vec2<TNumber> right)
        => left.Equals(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vec2<TNumber> left, Vec2<TNumber> right)
        => !(left == right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector128<TNumber> AsVector128Unsafe()
        => Unsafe.BitCast<Vec2<TNumber>, Vector128<TNumber>>(this);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector128<TNumber> AsLowerVector128Unsafe()
        => Unsafe.BitCast<Vector128<ulong>, Vector128<TNumber>>(Vector128.CreateScalar(Unsafe.BitCast<Vec2<TNumber>, ulong>(this)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector64<TNumber> AsVector64Unsafe()
        => Unsafe.BitCast<Vec2<TNumber>, Vector64<TNumber>>(this);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec2<TNumber> AsVec2Unsafe(Vector128<TNumber> v)
        => Unsafe.BitCast<Vector128<TNumber>, Vec2<TNumber>>(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec2<TNumber> AsVec2LowerUnsafe(Vector128<TNumber> v)
        => Unsafe.BitCast<ulong, Vec2<TNumber>>(Unsafe.BitCast<Vector128<TNumber>, Vector128<ulong>>(v).ToScalar());

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec2<TNumber> AsVec2Unsafe(Vector64<TNumber> v)
        => Unsafe.BitCast<Vector64<TNumber>, Vec2<TNumber>>(v);
}