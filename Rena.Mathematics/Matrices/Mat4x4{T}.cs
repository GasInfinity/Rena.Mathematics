using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Mat4x4<TNumber> : IMatrix<Mat4x4<TNumber>, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    public static int Rows
        => 4;

    public static int Columns
        => 4;

    public static Mat4x4<TNumber> Identity
        => new(Vec4<TNumber>.UnitX, Vec4<TNumber>.UnitY, Vec4<TNumber>.UnitZ, Vec4<TNumber>.UnitW);

    public Vec4<TNumber> X { get; init; }
    public Vec4<TNumber> Y { get; init; }
    public Vec4<TNumber> Z { get; init; }
    public Vec4<TNumber> W { get; init; }

    public Mat4x4(Vec4<TNumber> x, Vec4<TNumber> y, Vec4<TNumber> z, Vec4<TNumber> w)
        => (X, Y, Z, W) = (x, y, z, w);

    public Mat4x4(TNumber xx, TNumber xy, TNumber xz, TNumber xw,
                  TNumber yx, TNumber yy, TNumber yz, TNumber yw,
                  TNumber zx, TNumber zy, TNumber zz, TNumber zw,
                  TNumber wx, TNumber wy, TNumber wz, TNumber ww) : this(new(xx, xy, xz, xw), new(yx, yy, yz, yw), new(zx, zy, zz, zw), new(wx, wy, wz, ww))
    {
    }

    public Mat4x4<TNumber> Transpose() // TODO: Simd Shuffle
        => new(X.X, Y.X, Z.X, W.X,
               X.Y, Y.Y, Z.Y, W.Y,
               X.Z, Y.Z, Z.Z, W.Z,
               X.W, Y.W, Z.W, W.W);

    public override bool Equals(object? obj)
        => obj is Mat4x4<TNumber> mat && Equals(mat);

    public override int GetHashCode()
        => HashCode.Combine(X, Y, Z, W);

    public override string ToString()
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"({X},\n {Y},\n {Z},\n {W})";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"({X},\n {Y},\n {Z},\n {W})", out charsWritten);

}