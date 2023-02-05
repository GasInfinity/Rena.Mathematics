using System.Numerics;

namespace Rena.Mathematics;

public static class Quat
{
    public static Quat<TFloatingNumber> Axis<TFloatingNumber>(TFloatingNumber angle, TFloatingNumber x, TFloatingNumber y, TFloatingNumber z)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, ITrigonometricFunctions<TFloatingNumber>
    {
        (TFloatingNumber angleSin, TFloatingNumber angleCos) = TFloatingNumber.SinCos(angle / TFloatingNumber.CreateTruncating(2));

        return new(angleCos,
                   angleSin * TFloatingNumber.Cos(x),
                   angleSin * TFloatingNumber.Cos(y),
                   angleSin * TFloatingNumber.Cos(z));
    }

    public static Quat<TFloatingNumber> Euler<TFloatingNumber>(Radians<TFloatingNumber> x, Radians<TFloatingNumber> y, Radians<TFloatingNumber> z)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, ITrigonometricFunctions<TFloatingNumber>
    {
        (TFloatingNumber xSin, TFloatingNumber xCos) = TFloatingNumber.SinCos(x.Value / TFloatingNumber.CreateTruncating(2));
        (TFloatingNumber ySin, TFloatingNumber yCos) = TFloatingNumber.SinCos(y.Value / TFloatingNumber.CreateTruncating(2));
        (TFloatingNumber zSin, TFloatingNumber zCos) = TFloatingNumber.SinCos(z.Value / TFloatingNumber.CreateTruncating(2));

        return new(xCos * yCos * zCos + xSin * ySin * zSin,
                   xSin * yCos * zCos - xCos * ySin * zSin,
                   xCos * ySin * zCos + xSin * yCos * zSin,
                   xCos * yCos * zSin - xSin * ySin * zCos);
    }

    // The Vec3 stores the values as degrees
    public static Quat<TFloatingNumber> Euler<TFloatingNumber>(Vec3<TFloatingNumber> xyz)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, ITrigonometricFunctions<TFloatingNumber>
        => Euler(Radians<TFloatingNumber>.FromDegrees(xyz.X), Radians<TFloatingNumber>.FromDegrees(xyz.Y), Radians<TFloatingNumber>.FromDegrees(xyz.Z));

    public static TFloatingNumber Length<TFloatingNumber>(this Quat<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => TFloatingNumber.Sqrt(v.LengthSquared);

    public static Quat<TFloatingNumber> Unit<TFloatingNumber>(this Quat<TFloatingNumber> v)
        where TFloatingNumber : struct, INumberBase<TFloatingNumber>, IRootFunctions<TFloatingNumber>
        => v / v.Length();
    
    public static Quat<TSignedNumber> Conjugate<TSignedNumber>(this Quat<TSignedNumber> v)
        where TSignedNumber : struct, ISignedNumber<TSignedNumber>
        => new (v.W, -v.X, -v.Y, -v.Z);
    
    public static Vec3<TSignedNumber> Rotate<TSignedNumber>(this Quat<TSignedNumber> v, Vec3<TSignedNumber> position)
        where TSignedNumber : struct, ISignedNumber<TSignedNumber>
    {
        Vec3<TSignedNumber> vXyz = v.Xyz;
        Vec3<TSignedNumber> t = Vec3<TSignedNumber>.Cross(vXyz, position) * TSignedNumber.CreateTruncating(2);
        return position + (t * v.W) + Vec3<TSignedNumber>.Cross(vXyz, t);
    }
}