using System.Numerics;

namespace Rena.Mathematics;

public readonly partial struct Quat<TNumber>
    where TNumber : struct, INumberBase<TNumber>
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
        => (W, X, Y, Z) = (W, xyz.X, xyz.Y, xyz.Z);
}