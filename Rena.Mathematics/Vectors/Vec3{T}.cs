using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Vec3<TNumber> : INumericVector<Vec3<TNumber>, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    [SuppressMessage("Design", "RCS1158")]
    public static int Dimensions
        => 3;

    public static Vec3<TNumber> AdditiveIdentity
        => new(TNumber.Zero);

    public static readonly Vec3<TNumber> UnitX = new(TNumber.One, TNumber.Zero, TNumber.Zero);
    public static readonly Vec3<TNumber> UnitY = new(TNumber.Zero, TNumber.One, TNumber.Zero);
    public static readonly Vec3<TNumber> UnitZ = new(TNumber.Zero, TNumber.Zero, TNumber.One);

    public readonly TNumber X { get; init; }
    public readonly TNumber Y { get; init; }
    public readonly TNumber Z { get; init; }

    public TNumber LengthSquared
        => Dot(this, this);

    public Vec3(TNumber scalar)
        => (X, Y, Z) = (scalar, scalar, scalar);

    public Vec3(TNumber x, TNumber y, TNumber z)
        => (X, Y, Z) = (x, y, z);

    public Vec3(Vec2<TNumber> xy, TNumber z)
        => (X, Y, Z) = (xy.X, xy.Y, z);

    public override bool Equals(object? obj)
        => obj is Vec3<TNumber> v && Equals(v);

    public override int GetHashCode()
        => HashCode.Combine(X, Y, Z);

    public override string ToString()
        => $"({X}, {Y}, {Z})";
}