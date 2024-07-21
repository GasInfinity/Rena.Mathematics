using System.Numerics;
using System.Runtime.CompilerServices;

namespace Rena.Mathematics;

public static class Vec4
{
    public static TFloatingNumber Length<TFloatingNumber>(this Vec4<TFloatingNumber> v)
        where TFloatingNumber : INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Vec4<TFloatingNumber> Unit<TFloatingNumber>(this Vec4<TFloatingNumber> v)
        where TFloatingNumber : INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();
    
    public static TNumber DistanceSqr<TNumber>(this Vec4<TNumber> v, Vec4<TNumber> other)
        where TNumber : INumberBase<TNumber>
        => (v - other).LengthSquared;
    
    public static TFloatingNumber Distance<TFloatingNumber>(this Vec4<TFloatingNumber> v, Vec4<TFloatingNumber> other)
        where TFloatingNumber : INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(DistanceSqr(v, other));
    
    public static Vector4 AsVector4(this Vec4<float> vector)
        => Unsafe.BitCast<Vec4<float>, Vector4>(vector);

    public static Vec4<float> From(Vector4 vector)
        => Unsafe.BitCast<Vector4, Vec4<float>>(vector);
}