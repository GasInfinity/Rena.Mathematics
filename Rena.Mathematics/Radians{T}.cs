using System.Numerics;

namespace Rena.Mathematics;

public readonly struct Radians<TNumber>
    where TNumber : struct, INumberBase<TNumber>, IFloatingPointConstants<TNumber>
{
    private static readonly TNumber Rad2Deg = TNumber.CreateTruncating(180) / TNumber.Pi;
    private static readonly TNumber Deg2Rad = TNumber.Pi / TNumber.CreateTruncating(180);
    public TNumber Value { get; init; }

    public Radians(TNumber value)
        => Value = value;

    public override string ToString()
        => $"{Value}rad";

    public static explicit operator Degrees<TNumber>(Radians<TNumber> deg)
        => new(deg.Value * Rad2Deg);
    
    public static Radians<TNumber> FromDegrees(TNumber degrees)
        => new(degrees * Deg2Rad);
}