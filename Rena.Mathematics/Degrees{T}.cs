using System.Globalization;
using System.Numerics;

namespace Rena.Mathematics;

public readonly struct Degrees<TNumber>(TNumber value) : ISpanFormattable
    where TNumber : INumberBase<TNumber>, ITrigonometricFunctions<TNumber>
{
    public readonly TNumber Value = value;

    public override string ToString()
        => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => $"{Value}°";

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(CultureInfo.InvariantCulture, $"{Value}°", out charsWritten);

    public static explicit operator Radians<TNumber>(Degrees<TNumber> deg)
        => new(TNumber.DegreesToRadians(deg.Value));

    public static Degrees<TNumber> FromRadians(TNumber radians)
        => new(TNumber.RadiansToDegrees(radians));
}