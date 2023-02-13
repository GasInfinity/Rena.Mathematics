using System.Numerics;

namespace Rena.Mathematics;

public interface INumericVector<T, TNumber> : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, TNumber, T>, IDivisionOperators<T, TNumber, T>, IEqualityOperators<T, T, bool>, IEquatable<T>, ISpanFormattable
    where T : struct, INumericVector<T, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    static abstract int Dimensions { get; }

    TNumber LengthSquared { get; }

    static abstract T MultiplyComponents(T left, T right);
    static abstract T DivideComponents(T left, T right);
    static abstract TNumber Dot(T left, T right);
}