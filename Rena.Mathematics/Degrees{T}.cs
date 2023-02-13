using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly struct Degrees<TNumber> : ISpanFormattable
    where TNumber : struct, INumberBase<TNumber>, IFloatingPointConstants<TNumber>
{
    private static readonly TNumber Deg2Rad = TNumber.Pi / TNumber.CreateTruncating(180);
    private static readonly TNumber Rad2Deg = TNumber.CreateTruncating(180) / TNumber.Pi;

    public TNumber Value { get; init; }

    public Degrees(TNumber value)
        => Value = value;

    public override string ToString()
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"{Value}°";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"{Value}°", out charsWritten);

    public static explicit operator Radians<TNumber>(Degrees<TNumber> deg)
        => new(deg.Value * Deg2Rad);

    public static Degrees<TNumber> FromRadians(TNumber radians)
        => new(radians * Rad2Deg);
}