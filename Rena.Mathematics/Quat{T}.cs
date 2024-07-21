using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Quat<TNumber> : ISpanFormattable
    where TNumber : INumberBase<TNumber>
{
    public static readonly Quat<TNumber> Identity = new(TNumber.Zero, TNumber.Zero, TNumber.Zero, TNumber.One);

    public TNumber W { get; init; }
    public TNumber X { get; init; }
    public TNumber Y { get; init; }
    public TNumber Z { get; init; }

    public Vec3<TNumber> Xyz
        => new(X, Y, Z);

    public TNumber LengthSquared
        => Dot(this, this);

    public Quat(TNumber w, TNumber x, TNumber y, TNumber z)
        => (W, X, Y, Z) = (w, x, y, z);

    public Quat(TNumber w, Vec3<TNumber> xyz)
        => (W, X, Y, Z) = (w, xyz.X, xyz.Y, xyz.Z);

    public override string ToString()
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"({W}, {X}, {Y}, {Z})";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"({W}, {X}, {Y}, {Z})", out charsWritten);
}