using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Rena.Mathematics;

[SkipLocalsInit]
public unsafe readonly partial struct Vec4<TNumber>
{
    public static explicit operator Vec2<TNumber>(Vec4<TNumber> self)
        => Unsafe.As<Vec4<TNumber>, Vec2<TNumber>>(ref self);

    public static explicit operator Vec4<TNumber>(Vec2<TNumber> self)
        => new(self, TNumber.Zero, TNumber.Zero);

    public static explicit operator Vec3<TNumber>(Vec4<TNumber> self)
        => Unsafe.As<Vec4<TNumber>, Vec3<TNumber>>(ref self);

    public static explicit operator Vec4<TNumber>(Vec3<TNumber> self)
        => new(self, TNumber.Zero);

#pragma warning disable CS8500 // This takes the size of a managed type... (Ok? Thats what I want)
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Vec4<TNumber> other)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return this.AsVector256Unsafe() == other.AsVector256Unsafe();

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return this.AsVector128Unsafe() == other.AsVector128Unsafe();

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return this.AsLowerVector128Unsafe() == other.AsLowerVector128Unsafe();

            return this.AsVector64Unsafe() == other.AsVector64Unsafe();
        }

        return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> MultiplyComponents(Vec4<TNumber> left, Vec4<TNumber> right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector256Unsafe() * right.AsVector256Unsafe());

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector128Unsafe() * right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec4LowerUnsafe(left.AsLowerVector128Unsafe() * right.AsLowerVector128Unsafe());

            return AsVec4Unsafe(left.AsVector64Unsafe() * right.AsVector64Unsafe());
        }

        return new(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> DivideComponents(Vec4<TNumber> left, Vec4<TNumber> right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector256Unsafe() / right.AsVector256Unsafe());

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector128Unsafe() / right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec4LowerUnsafe(left.AsLowerVector128Unsafe() / right.AsLowerVector128Unsafe());

            return AsVec4Unsafe(left.AsVector64Unsafe() / right.AsVector64Unsafe());
        }

        return new(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber Dot(Vec4<TNumber> left, Vec4<TNumber> right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return Vector256.Dot(left.AsVector256Unsafe(), right.AsVector256Unsafe());

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return Vector128.Dot(left.AsVector128Unsafe(), right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return Vector128.Dot(left.AsLowerVector128Unsafe(), right.AsLowerVector128Unsafe());

            return Vector64.Dot(left.AsVector64Unsafe(), right.AsVector64Unsafe());
        }

        return (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator +(Vec4<TNumber> left, Vec4<TNumber> right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector256Unsafe() + right.AsVector256Unsafe());

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector128Unsafe() + right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec4LowerUnsafe(left.AsLowerVector128Unsafe() + right.AsLowerVector128Unsafe());

            return AsVec4Unsafe(left.AsVector64Unsafe() + right.AsVector64Unsafe());
        }

        return new(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator -(Vec4<TNumber> left, Vec4<TNumber> right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector256Unsafe() - right.AsVector256Unsafe());

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector128Unsafe() - right.AsVector128Unsafe());

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec4LowerUnsafe(left.AsLowerVector128Unsafe() - right.AsLowerVector128Unsafe());

            return AsVec4Unsafe(left.AsVector64Unsafe() - right.AsVector64Unsafe());
        }

        return new(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator *(Vec4<TNumber> left, TNumber right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector256Unsafe() * Vector256.Create(right));

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector128Unsafe() * Vector128.Create(right));

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec4LowerUnsafe(left.AsLowerVector128Unsafe() * Vector128.Create(right));

            return AsVec4Unsafe(left.AsVector64Unsafe() * Vector64.Create(right));
        }

        return new(left.X * right, left.Y * right, left.Z * right, left.W * right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vec4<TNumber> operator /(Vec4<TNumber> left, TNumber right)
    {
        if (sizeof(Vector256<TNumber>) == sizeof(Vec4<TNumber>) && Vector256<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector256Unsafe() / Vector256.Create(right));

        if (sizeof(Vector128<TNumber>) == sizeof(Vec4<TNumber>) && Vector128<TNumber>.IsSupported)
            return AsVec4Unsafe(left.AsVector128Unsafe() / Vector128.Create(right));

        if (sizeof(Vector64<TNumber>) == sizeof(Vec4<TNumber>) && Vector64<TNumber>.IsSupported)
        {
            if (!Vector64.IsHardwareAccelerated && Vector128.IsHardwareAccelerated) // e.g: x86_64
                return AsVec4LowerUnsafe(left.AsLowerVector128Unsafe() / Vector128.Create(right));

            return AsVec4Unsafe(left.AsVector64Unsafe() / Vector64.Create(right));
        }

        return new(left.X / right, left.Y / right, left.Z / right, left.W / right);
    }
#pragma warning restore CS8500 // This takes the size of a managed type... (Ok? Thats what I want)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vec4<TNumber> left, Vec4<TNumber> right)
        => left.Equals(right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vec4<TNumber> left, Vec4<TNumber> right)
        => !(left == right);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector256<TNumber> AsVector256Unsafe()
        => Unsafe.BitCast<Vec4<TNumber>, Vector256<TNumber>>(this);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector128<TNumber> AsVector128Unsafe()
        => Unsafe.BitCast<Vec4<TNumber>, Vector128<TNumber>>(this);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector128<TNumber> AsLowerVector128Unsafe()
        => Unsafe.BitCast<Vector128<ulong>, Vector128<TNumber>>(Vector128.CreateScalar(Unsafe.BitCast<Vec4<TNumber>, ulong>(this)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Vector64<TNumber> AsVector64Unsafe()
        => Unsafe.BitCast<Vec4<TNumber>, Vector64<TNumber>>(this);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec4<TNumber> AsVec4Unsafe(Vector256<TNumber> v)
        => Unsafe.BitCast<Vector256<TNumber>, Vec4<TNumber>>(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec4<TNumber> AsVec4Unsafe(Vector128<TNumber> v)
        => Unsafe.BitCast<Vector128<TNumber>, Vec4<TNumber>>(v);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec4<TNumber> AsVec4LowerUnsafe(Vector128<TNumber> v)
        => Unsafe.BitCast<ulong, Vec4<TNumber>>(Unsafe.BitCast<Vector128<TNumber>, Vector128<ulong>>(v).ToScalar());

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Vec4<TNumber> AsVec4Unsafe(Vector64<TNumber> v)
        => Unsafe.BitCast<Vector64<TNumber>, Vec4<TNumber>>(v);
}