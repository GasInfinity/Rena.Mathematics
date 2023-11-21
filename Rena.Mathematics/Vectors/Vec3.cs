using System.Numerics;
using System.Runtime.CompilerServices;

namespace Rena.Mathematics;

public static class Vec3
{
    public static TFloatingNumber Length<TFloatingNumber>(this Vec3<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Vec3<TFloatingNumber> Normalized<TFloatingNumber>(this Vec3<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();

    public static TNumber DistanceSqr<TNumber>(this Vec3<TNumber> v, Vec3<TNumber> other)
        where TNumber : struct, INumberBase<TNumber>
        => (v - other).LengthSquared;
    
    public static TFloatingNumber Distance<TFloatingNumber>(this Vec3<TFloatingNumber> v, Vec3<TFloatingNumber> other)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(DistanceSqr(v, other));
    
    public static Vector3 AsVector3(this Vec3<float> vector)
        => Unsafe.BitCast<Vec3<float>, Vector3>(vector);

    public static Vec3<float> From(Vector3 vector)
        => Unsafe.BitCast<Vector3, Vec3<float>>(vector);
}