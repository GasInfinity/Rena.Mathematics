using System.Numerics;

namespace Rena.Mathematics;

public static class Vec2
{
    public static TFloatingNumber Length<TFloatingNumber>(this Vec2<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Vec2<TFloatingNumber> Unit<TFloatingNumber>(this Vec2<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();

    public static Vec2<TSignedNumber> PerpendicularLeft<TSignedNumber>(this Vec2<TSignedNumber> v)
        where TSignedNumber : struct, ISignedNumber<TSignedNumber>
        => new(-v.Y, v.X);

    public static Vec2<TSignedNumber> PerpendicularRight<TSignedNumber>(this Vec2<TSignedNumber> v)
        where TSignedNumber : struct, ISignedNumber<TSignedNumber>
        => new(v.Y, -v.X);
}