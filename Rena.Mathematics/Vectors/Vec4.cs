using System.Numerics;

namespace Rena.Mathematics;

public static class Vec4
{
    public static TFloatingNumber Length<TFloatingNumber>(this Vec4<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Vec4<TFloatingNumber> Unit<TFloatingNumber>(this Vec4<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();
}