using System.Numerics;

namespace Rena.Mathematics;

public static class Mat3x3
{
    public static Mat3x3<TNumber> Translation<TNumber>(TNumber x, TNumber y)
        where TNumber : struct, INumberBase<TNumber>
        => new(TNumber.One, TNumber.Zero, x,
               TNumber.Zero, TNumber.One, y,
               TNumber.Zero, TNumber.Zero, TNumber.One);

    public static Mat3x3<TNumber> Translation<TNumber>(Vec2<TNumber> xy)
        where TNumber : struct, INumberBase<TNumber>
        => Translation(xy.X, xy.Y);

    public static Mat3x3<TNumber> Rotation<TNumber>(Radians<TNumber> angle)
        where TNumber : struct, INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
    {
        (TNumber sinAngle, TNumber cosAngle) = TNumber.SinCos(angle.Value);
        return new(cosAngle, sinAngle, TNumber.Zero,
                   -sinAngle, cosAngle, TNumber.Zero,
                   TNumber.Zero, TNumber.Zero, TNumber.One);
    }

    public static Mat3x3<TNumber> Scale<TNumber>(TNumber x, TNumber y)
        where TNumber : struct, INumberBase<TNumber>
        => new(x, TNumber.Zero, TNumber.Zero, 
               TNumber.Zero, y, TNumber.Zero,
               TNumber.Zero, TNumber.Zero, TNumber.One);

    public static Mat3x3<TNumber> Scale<TNumber>(Vec2<TNumber> xy)
        where TNumber : struct, INumberBase<TNumber>
        => Scale(xy.X, xy.Y);
    
    public static Mat3x3<TNumber> Shear<TNumber>(TNumber x, TNumber y)
        where TNumber : struct, INumberBase<TNumber>
        => new(TNumber.One, x, TNumber.Zero,
               y, TNumber.One, TNumber.Zero,
               TNumber.Zero, TNumber.Zero, TNumber.One);
    
    public static Mat3x3<TNumber> Shear<TNumber>(Vec2<TNumber> xy)
        where TNumber : struct, INumberBase<TNumber>
        => Shear(xy.X, xy.Y);
    
    public static Mat3x3<TNumber> Ortho<TNumber>(TNumber left, TNumber top, TNumber right, TNumber bottom)
        where TNumber : struct, INumberBase<TNumber>
    {
        TNumber rightMinusLeft = right - left;
        TNumber topMinusBottom = top - bottom;
        
        return new(TNumber.CreateTruncating(2) / rightMinusLeft, TNumber.Zero, -((right + left) / (rightMinusLeft)),
                   TNumber.Zero, TNumber.CreateTruncating(2) / topMinusBottom, -((top + bottom) / (topMinusBottom)),
                   TNumber.Zero, TNumber.Zero, TNumber.One);
    }
}