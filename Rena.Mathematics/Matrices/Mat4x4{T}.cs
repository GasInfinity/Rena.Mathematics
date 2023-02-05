using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Mat4x4<TNumber> : IMatrix<Mat4x4<TNumber>, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    [SuppressMessage("Design", "RCS1158")]
    public static int Rows
        => 4;

    [SuppressMessage("Design", "RCS1158")]
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

    public override bool Equals(object? obj)
        => obj is Mat4x4<TNumber> mat && Equals(mat);

    public override int GetHashCode()
        => HashCode.Combine(X, Y, Z, W);

    public override string ToString()
        => $"({X},\n {Y},\n {Z},\n {W})";

    public static Mat4x4<TNumber> Translation(TNumber x, TNumber y, TNumber z)
        => new(TNumber.One, TNumber.Zero, TNumber.Zero, x,
               TNumber.Zero, TNumber.One, TNumber.Zero, y,
               TNumber.Zero, TNumber.Zero, TNumber.One, z,
               TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public static Mat4x4<TNumber> Translation(Vec3<TNumber> xyz)
        => Translation(xyz.X, xyz.Y, xyz.Z);

    public static Mat4x4<TNumber> Rotation()
    {
        return default;
    }

    public static Mat4x4<TNumber> Scale(TNumber x, TNumber y, TNumber z)
        => new(x, TNumber.Zero, TNumber.Zero, TNumber.Zero,
               TNumber.Zero, y, TNumber.Zero, TNumber.Zero,
               TNumber.Zero, TNumber.Zero, z, TNumber.Zero,
               TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public static Mat4x4<TNumber> Scale(Vec3<TNumber> xyz)
        => Scale(xyz.X, xyz.Y, xyz.Z);
}