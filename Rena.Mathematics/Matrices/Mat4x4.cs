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

        return new(TNumber.CreateTruncating(2) / rightMinusLeft, TNumber.Zero, TNumber.Zero, -((right + left) / (rightMinusLeft)),
                   TNumber.Zero, TNumber.CreateTruncating(2) / topMinusBottom, TNumber.Zero, -((top + bottom) / (topMinusBottom)),
                   TNumber.Zero, TNumber.Zero, TNumber.CreateTruncating(-2) / farMinusNear, -((far + near) / (farMinusNear)),
                   TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);
    }
}