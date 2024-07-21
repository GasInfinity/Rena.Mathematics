using System.Numerics;

namespace Rena.Mathematics;

public static class Mat4x4
{
    public static Mat4x4<TNumber> Translation<TNumber>(TNumber x, TNumber y, TNumber z)
        where TNumber : struct, INumberBase<TNumber>
        => new(TNumber.One, TNumber.Zero, TNumber.Zero, x,
               TNumber.Zero, TNumber.One, TNumber.Zero, y,
               TNumber.Zero, TNumber.Zero, TNumber.One, z,
               TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public static Mat4x4<TNumber> Translation<TNumber>(Vec3<TNumber> xyz)
        where TNumber : struct, INumberBase<TNumber>
        => Translation(xyz.X, xyz.Y, xyz.Z);

    public static Mat4x4<TNumber> Rotation<TNumber>(Quat<TNumber> q)
        where TNumber : struct, INumberBase<TNumber>
    {
        return new(TNumber.One - TNumber.CreateTruncating(2) * ((q.Y * q.Y) - (q.Z * q.Z)), TNumber.CreateTruncating(2) * ((q.X * q.Y) - (q.Z * q.W)), TNumber.CreateTruncating(2) * ((q.X * q.Z) + (q.Y * q.W)), TNumber.Zero,
                   TNumber.CreateTruncating(2) * ((q.X * q.Y) + (q.Z * q.W)), TNumber.One - TNumber.CreateTruncating(2) * ((q.X * q.X) - (q.Z * q.Z)), TNumber.CreateTruncating(2) * ((q.Y * q.Z) - (q.X * q.W)), TNumber.Zero,
                   TNumber.CreateTruncating(2) * ((q.X * q.Z) - (q.Y * q.W)), TNumber.CreateTruncating(2) * ((q.Y * q.Z) + (q.X * q.W)), TNumber.One - TNumber.CreateTruncating(2) * ((q.X * q.X) - (q.Y * q.Y)), TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }

    public static Mat4x4<TNumber> RotationX<TNumber>(Radians<TNumber> x)
        where TNumber : struct, INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
    {
        (TNumber sinX, TNumber cosX) = TNumber.SinCos(x.Value);
        
        return new(TNumber.One, TNumber.Zero, TNumber.Zero, TNumber.Zero,
                   TNumber.Zero, cosX, -sinX, TNumber.Zero,
                   TNumber.Zero, sinX, cosX, TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }

    public static Mat4x4<TNumber> RotationY<TNumber>(Radians<TNumber> y)
        where TNumber : struct, INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
    {
        (TNumber sinY, TNumber cosY) = TNumber.SinCos(y.Value);

        return new(cosY, TNumber.Zero, sinY, TNumber.Zero,
                   TNumber.Zero, TNumber.One, TNumber.Zero, TNumber.Zero,
                   -sinY, TNumber.Zero, cosY, TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }

    public static Mat4x4<TNumber> RotationZ<TNumber>(Radians<TNumber> z)
        where TNumber : struct, INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
    {
        (TNumber sinZ, TNumber cosZ) = TNumber.SinCos(z.Value);

        return new(cosZ, -sinZ, TNumber.Zero, TNumber.Zero,
                   sinZ, cosZ, TNumber.Zero, TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, TNumber.One, TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }

    public static Mat4x4<TNumber> Scale<TNumber>(TNumber x, TNumber y, TNumber z)
        where TNumber : struct, INumberBase<TNumber>
        => new(x, TNumber.Zero, TNumber.Zero, TNumber.Zero,
               TNumber.Zero, y, TNumber.Zero, TNumber.Zero,
               TNumber.Zero, TNumber.Zero, z, TNumber.Zero,
               TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public static Mat4x4<TNumber> Scale<TNumber>(Vec3<TNumber> xyz)
        where TNumber : struct, INumberBase<TNumber>
        => Scale(xyz.X, xyz.Y, xyz.Z);

    public static Mat4x4<TNumber> Ortho<TNumber>(TNumber left, TNumber top, TNumber right, TNumber bottom, TNumber near, TNumber far)
        where TNumber : struct, INumberBase<TNumber>
    {
        TNumber rightMinusLeft = right - left;
        TNumber topMinusBottom = top - bottom;
        TNumber farMinusNear = far - near;

        return new(TNumber.CreateTruncating(2) / rightMinusLeft, TNumber.Zero, TNumber.Zero, -((right + left) / rightMinusLeft),
                   TNumber.Zero, TNumber.CreateTruncating(2) / topMinusBottom, TNumber.Zero, -((top + bottom) / topMinusBottom),
                   TNumber.Zero, TNumber.Zero, TNumber.CreateTruncating(-2) / farMinusNear, -((far + near) / farMinusNear),
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }

    public static Mat4x4<TNumber> Perspective<TNumber>(TNumber aspect, Radians<TNumber> fov, TNumber near, TNumber far)
        where TNumber : struct, INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
    {
        TNumber tanHalfFov = TNumber.Tan(fov.Value / TNumber.CreateTruncating(2));
        TNumber nearMinusFar = near - far;

        return new(TNumber.One / (aspect * tanHalfFov), TNumber.Zero, TNumber.Zero, TNumber.Zero,
                   TNumber.Zero, TNumber.One / tanHalfFov, TNumber.Zero, TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, -nearMinusFar / nearMinusFar, (TNumber.CreateTruncating(2) * far * near) / nearMinusFar,
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }
}