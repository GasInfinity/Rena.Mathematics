using System.Numerics;

namespace Rena.Mathematics;

public interface IMatrix<T, TNumber> : IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, TNumber, T>, IDivisionOperators<T, TNumber, T>, IEquatable<T>, IEqualityOperators<T, T, bool>
    where T : struct, IMatrix<T, TNumber>
    where TNumber : struct, INumberBase<TNumber>
{
    static abstract int Rows { get; }
    static abstract int Columns { get; }

    static abstract T Identity { get; }
}