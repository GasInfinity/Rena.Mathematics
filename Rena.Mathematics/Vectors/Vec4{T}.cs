using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Vec4<TNumber> : INumericVector<Vec4<TNumber>, TNumber>
    where TNumber : INumberBase<TNumber>
{
    public static int Dimensions
        => 4;

    public static Vec4<TNumber> AdditiveIdentity
        => new(TNumber.Zero);

    public static readonly Vec4<TNumber> UnitX = new(TNumber.One, TNumber.Zero, TNumber.Zero, TNumber.Zero);
    public static readonly Vec4<TNumber> UnitY = new(TNumber.Zero, TNumber.One, TNumber.Zero, TNumber.Zero);
    public static readonly Vec4<TNumber> UnitZ = new(TNumber.Zero, TNumber.Zero, TNumber.One, TNumber.Zero);
    public static readonly Vec4<TNumber> UnitW = new(TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public readonly TNumber X;
    public readonly TNumber Y;
    public readonly TNumber Z;
    public readonly TNumber W;

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
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"({X}, {Y}, {Z}, {W})";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"({X}, {Y}, {Z}, {W})", out charsWritten);

    public static Vec4<TNumber> CreateTruncating<TOtherNumber>(Vec4<TOtherNumber> other)
        where TOtherNumber : struct, INumberBase<TOtherNumber>
        => new(TNumber.CreateTruncating(other.X), TNumber.CreateTruncating(other.Y), TNumber.CreateTruncating(other.Z), TNumber.CreateTruncating(other.W));

    public static Vec4<TNumber> CreateSaturating<TOtherNumber>(Vec4<TOtherNumber> other)
        where TOtherNumber : struct, INumberBase<TOtherNumber>
        => new(TNumber.CreateSaturating(other.X), TNumber.CreateSaturating(other.Y), TNumber.CreateSaturating(other.Z), TNumber.CreateSaturating(other.W));
}