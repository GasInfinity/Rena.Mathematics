using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Mat3x3<TNumber> : IMatrix<Mat3x3<TNumber>, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    public static int Rows
        => 3;

    public static int Columns
        => 3;

    public static Mat3x3<TNumber> Identity
        => new(Vec3<TNumber>.UnitX, Vec3<TNumber>.UnitY, Vec3<TNumber>.UnitZ);

    public readonly Vec3<TNumber> X;
    public readonly Vec3<TNumber> Y;
    public readonly Vec3<TNumber> Z;

    public Mat3x3(Vec3<TNumber> x, Vec3<TNumber> y, Vec3<TNumber> z)
        => (X, Y, Z) = (x, y, z);

    public Mat3x3(TNumber xx, TNumber xy, TNumber xz,
                  TNumber yx, TNumber yy, TNumber yz,
                  TNumber zx, TNumber zy, TNumber zz) : this(new(xx, xy, xz), new(yx, yy, yz), new(zx, zy, zz))
    {
    }

    public Mat3x3<TNumber> Transpose()
        => new(X.X, Y.X, Z.X,
               X.Y, Y.Y, Z.Y,
               X.Z, Y.Z, Z.Z);

    public override bool Equals(object? obj)
        => obj is Mat3x3<TNumber> mat && Equals(mat);

    public override int GetHashCode()
        => HashCode.Combine(X, Y, Z);

    public override string ToString()
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"({X},\n {Y},\n {Z})";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"({X},\n {Y},\n {Z})", out charsWritten);
}