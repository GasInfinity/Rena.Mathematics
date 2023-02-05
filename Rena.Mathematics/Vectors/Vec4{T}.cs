using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Vec4<TNumber> : INumericVector<Vec4<TNumber>, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    [SuppressMessage("Design", "RCS1158")]
    public static int Dimensions
        => 2;

    public static Vec4<TNumber> AdditiveIdentity
        => new(TNumber.Zero);

    public static readonly Vec4<TNumber> UnitX = new(TNumber.One, TNumber.Zero, TNumber.Zero, TNumber.Zero);
    public static readonly Vec4<TNumber> UnitY = new(TNumber.Zero, TNumber.One, TNumber.Zero, TNumber.Zero);
    public static readonly Vec4<TNumber> UnitZ = new(TNumber.Zero, TNumber.Zero, TNumber.One, TNumber.Zero);
    public static readonly Vec4<TNumber> UnitW = new(TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public readonly TNumber X { get; init; }
    public readonly TNumber Y { get; init; }
    public readonly TNumber Z { get; init; }
    public readonly TNumber W { get; init; }

    public TNumber LengthSquared
        => Dot(this, this);

    public Vec4(TNumber scalar)
        => (X, Y, Z, W) = (scalar, scalar, scalar, scalar);

    public Vec4(TNumber x, TNumber y, TNumber z, TNumber w)
        => (X, Y, Z, W) = (x, y, z, w);

    public Vec4(Vec2<TNumber> xy, TNumber z, TNumber w)
        => (X, Y, Z, W) = (xy.X, xy.Y, z, w);

    public Vec4(Vec3<TNumber> xyz, TNumber w)
        => (X, Y, Z, W) = (xyz.X, xyz.Y, xyz.Z, w);

    public override bool Equals(object? obj)
        => obj is Vec2<TNumber> v && Equals(v);

    public override int GetHashCode()
        => HashCode.Combine(X, Y, Z, W);

    public override string ToString()
        => $"({X}, {Y}, {Z}, {W})";
}