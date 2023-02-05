using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Vec2<TNumber> : INumericVector<Vec2<TNumber>, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    [SuppressMessage("Design", "RCS1158")]
    public static int Dimensions
        => 2;

    public static Vec2<TNumber> AdditiveIdentity
        => new(TNumber.Zero);

    public static readonly Vec2<TNumber> UnitX = new(TNumber.One, TNumber.Zero);
    public static readonly Vec2<TNumber> UnitY = new(TNumber.Zero, TNumber.One);

    public readonly TNumber X { get; init; }
    public readonly TNumber Y { get; init; }
    
    public TNumber LengthSquared
        => Dot(this, this);

    public Vec2(TNumber scalar)
        => (X, Y) = (scalar, scalar);

    public Vec2(TNumber x, TNumber y)
        => (X, Y) = (x, y);

    public override bool Equals(object? obj)
        => obj is Vec2<TNumber> v && Equals(v);

    public override int GetHashCode()
        => HashCode.Combine(X, Y);

    public override string ToString()
        => $"({X}, {Y})";
}