using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly struct Radians<TNumber>(TNumber value) : ISpanFormattable
    where TNumber : INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
{
    public readonly TNumber Value = value;

    public override string ToString()
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"{Value}rad";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"{Value}rad", out charsWritten);

    public static explicit operator Degrees<TNumber>(Radians<TNumber> rad)
        => new(TNumber.RadiansToDegrees(rad.Value));

    public static Radians<TNumber> FromDegrees(TNumber deg)
        => new(TNumber.DegreesToRadians(deg));
}