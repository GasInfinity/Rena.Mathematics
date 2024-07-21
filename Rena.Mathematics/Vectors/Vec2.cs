using System.Numerics;
using System.Runtime.CompilerServices;

namespace Rena.Mathematics;

public static class Vec2
{
    public static TFloatingNumber Length<TFloatingNumber>(this Vec2<TFloatingNumber> v)
        where TFloatingNumber : INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Vec2<TFloatingNumber> Unit<TFloatingNumber>(this Vec2<TFloatingNumber> v)
        where TFloatingNumber : INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();

    public static Vec2<TSignedNumber> PerpendicularLeft<TSignedNumber>(this Vec2<TSignedNumber> v)
        where TSignedNumber : ISignedNumber<TSignedNumber>
        => new(-v.Y, v.X);

    public static Vec2<TSignedNumber> PerpendicularRight<TSignedNumber>(this Vec2<TSignedNumber> v)
        where TSignedNumber : ISignedNumber<TSignedNumber>
        => new(v.Y, -v.X);

    public static TNumber DistanceSqr<TNumber>(this Vec2<TNumber> v, Vec2<TNumber> other)
        where TNumber : INumberBase<TNumber>
        => (v - other).LengthSquared;

    public static TFloatingNumber Distance<TFloatingNumber>(this Vec2<TFloatingNumber> v, Vec2<TFloatingNumber> other)
        where TFloatingNumber : INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(DistanceSqr(v, other));

    public static Vector2 AsVector2(this Vec2<float> vector)
        => Unsafe.BitCast<Vec2<float>, Vector2>(vector);

    public static Vec2<float> From(Vector2 vector)
        => Unsafe.BitCast<Vector2, Vec2<float>>(vector);
}