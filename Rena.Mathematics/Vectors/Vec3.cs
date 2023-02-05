using System.Numerics;

namespace Rena.Mathematics;

public static class Vec3
{
    public static TFloatingNumber Length<TFloatingNumber>(this Vec3<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Vec3<TFloatingNumber> Normalized<TFloatingNumber>(this Vec3<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();
}