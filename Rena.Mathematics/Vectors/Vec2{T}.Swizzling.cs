namespace Rena.Mathematics;

public partial struct Vec2<TNumber>
{
    #region Vec2 Swizzling
    public Vec2<TNumber> Xx
        => new(X, X);

    public Vec2<TNumber> Xy
        => new(X, Y);

    public Vec2<TNumber> Yx
        => new(Y, X);

    public Vec2<TNumber> Yy
        => new(Y, Y);
    #endregion

    #region Vec3 Swizzling
    public Vec3<TNumber> Xxx
        => new(X, X, X);

    public Vec3<TNumber> Xxy
        => new(X, X, Y);

    public Vec3<TNumber> Xyx
        => new(X, Y, X);

    public Vec3<TNumber> Xyy
        => new(X, Y, Y);

    public Vec3<TNumber> Yxx
        => new(Y, X, X);

    public Vec3<TNumber> Yxy
        => new(Y, X, Y);

    public Vec3<TNumber> Yyx
        => new(Y, Y, X);

    public Vec3<TNumber> Yyy
        => new(Y, Y, Y);
    #endregion

    #region Vec4 Swizzling
    public Vec4<TNumber> Xxxx
        => new(X, X, X, X);

    public Vec4<TNumber> Xxxy
        => new(X, X, X, Y);

    public Vec4<TNumber> Xxyx
        => new(X, X, Y, X);

    public Vec4<TNumber> Xxyy
        => new(X, X, Y, Y);

    public Vec4<TNumber> Xyxx
        => new(X, Y, X, X);

    public Vec4<TNumber> Xyxy
        => new(X, Y, X, Y);

    public Vec4<TNumber> Xyyx
        => new(X, Y, Y, X);

    public Vec4<TNumber> Xyyy
        => new(X, Y, Y, Y);

    public Vec4<TNumber> Yxxx
        => new(Y, X, X, X);

    public Vec4<TNumber> Yxxy
        => new(Y, X, X, Y);

    public Vec4<TNumber> Yxyx
        => new(Y, X, Y, X);

    public Vec4<TNumber> Yxyy
        => new(Y, X, Y, Y);

    public Vec4<TNumber> Yyxx
        => new(Y, Y, X, X);

    public Vec4<TNumber> Yyxy
        => new(Y, Y, X, Y);

    public Vec4<TNumber> Yyyx
        => new(Y, Y, Y, X);

    public Vec4<TNumber> Yyyy
        => new(Y, Y, Y, Y);
    #endregion
}