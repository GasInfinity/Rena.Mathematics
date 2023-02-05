namespace Rena.Mathematics;

public partial struct Vec4<TNumber>
{
    #region Vec2 Swizzling
    public Vec2<TNumber> Xx
        => new(X, X);

    public Vec2<TNumber> Xy
        => new(X, Y);

    public Vec2<TNumber> Xz
        => new(X, Z);

    public Vec2<TNumber> Xw
        => new(X, W);

    public Vec2<TNumber> Yx
        => new(Y, X);

    public Vec2<TNumber> Yy
        => new(Y, Y);

    public Vec2<TNumber> Yz
        => new(Y, Z);

    public Vec2<TNumber> Yw
        => new(Y, W);

    public Vec2<TNumber> Zx
        => new(Z, X);

    public Vec2<TNumber> Zy
        => new(Z, Y);

    public Vec2<TNumber> Zz
        => new(Z, Z);

    public Vec2<TNumber> Zw
        => new(Z, W);

    public Vec2<TNumber> Wx
        => new(W, X);

    public Vec2<TNumber> Wy
        => new(W, Y);

    public Vec2<TNumber> Wz
        => new(W, Z);

    public Vec2<TNumber> Ww
        => new(W, W);
    #endregion

    #region Vec3 Swizzling
    public Vec3<TNumber> Xxx
        => new(X, X, X);

    public Vec3<TNumber> Xxy
        => new(X, X, Y);

    public Vec3<TNumber> Xxz
        => new(X, X, Z);

    public Vec3<TNumber> Xxw
        => new(X, X, W);

    public Vec3<TNumber> Xyx
        => new(X, Y, X);

    public Vec3<TNumber> Xyy
        => new(X, Y, Y);

    public Vec3<TNumber> Xyz
        => new(X, Y, Z);

    public Vec3<TNumber> Xyw
        => new(X, Y, W);

    public Vec3<TNumber> Xzx
        => new(X, Z, X);

    public Vec3<TNumber> Xzy
        => new(X, Z, Y);

    public Vec3<TNumber> Xzz
        => new(X, Z, Z);

    public Vec3<TNumber> Xzw
        => new(X, Z, W);

    public Vec3<TNumber> Xwx
        => new(X, W, X);

    public Vec3<TNumber> Xwy
        => new(X, W, Y);

    public Vec3<TNumber> Xwz
        => new(X, W, Z);

    public Vec3<TNumber> Xww
        => new(X, W, W);

    public Vec3<TNumber> Yxx
        => new(Y, X, X);

    public Vec3<TNumber> Yxy
        => new(Y, X, Y);

    public Vec3<TNumber> Yxz
        => new(Y, X, Z);

    public Vec3<TNumber> Yxw
        => new(Y, X, W);

    public Vec3<TNumber> Yyx
        => new(Y, Y, X);

    public Vec3<TNumber> Yyy
        => new(Y, Y, Y);

    public Vec3<TNumber> Yyz
        => new(Y, Y, Z);

    public Vec3<TNumber> Yyw
        => new(Y, Y, W);

    public Vec3<TNumber> Yzx
        => new(Y, Z, X);

    public Vec3<TNumber> Yzy
        => new(Y, Z, Y);

    public Vec3<TNumber> Yzz
        => new(Y, Z, Z);

    public Vec3<TNumber> Yzw
        => new(Y, Z, W);

    public Vec3<TNumber> Ywx
        => new(Y, W, X);

    public Vec3<TNumber> Ywy
        => new(Y, W, Y);

    public Vec3<TNumber> Ywz
        => new(Y, W, Z);

    public Vec3<TNumber> Yww
        => new(Y, W, W);

    public Vec3<TNumber> Zxx
        => new(Z, X, X);

    public Vec3<TNumber> Zxy
        => new(Z, X, Y);

    public Vec3<TNumber> Zxz
        => new(Z, X, Z);

    public Vec3<TNumber> Zxw
        => new(Z, X, W);

    public Vec3<TNumber> Zyx
        => new(Z, Y, X);

    public Vec3<TNumber> Zyy
        => new(Z, Y, Y);

    public Vec3<TNumber> Zyz
        => new(Z, Y, Z);

    public Vec3<TNumber> Zyw
        => new(Z, Y, W);

    public Vec3<TNumber> Zzx
        => new(Z, Z, X);

    public Vec3<TNumber> Zzy
        => new(Z, Z, Y);

    public Vec3<TNumber> Zzz
        => new(Z, Z, Z);

    public Vec3<TNumber> Zzw
        => new(Z, Z, W);

    public Vec3<TNumber> Zwx
        => new(Z, W, X);

    public Vec3<TNumber> Zwy
        => new(Z, W, Y);

    public Vec3<TNumber> Zwz
        => new(Z, W, Z);

    public Vec3<TNumber> Zww
        => new(Z, W, W);

    public Vec3<TNumber> Wxx
        => new(W, X, X);

    public Vec3<TNumber> Wxy
        => new(W, X, Y);

    public Vec3<TNumber> Wxz
        => new(W, X, Z);

    public Vec3<TNumber> Wxw
        => new(W, X, W);

    public Vec3<TNumber> Wyx
        => new(W, Y, X);

    public Vec3<TNumber> Wyy
        => new(W, Y, Y);

    public Vec3<TNumber> Wyz
        => new(W, Y, Z);

    public Vec3<TNumber> Wyw
        => new(W, Y, W);

    public Vec3<TNumber> Wzx
        => new(W, Z, X);

    public Vec3<TNumber> Wzy
        => new(W, Z, Y);

    public Vec3<TNumber> Wzz
        => new(W, Z, Z);

    public Vec3<TNumber> Wzw
        => new(W, Z, W);

    public Vec3<TNumber> Wwx
        => new(W, W, X);

    public Vec3<TNumber> Wwy
        => new(W, W, Y);

    public Vec3<TNumber> Wwz
        => new(W, W, Z);

    public Vec3<TNumber> Www
        => new(W, W, W);
    #endregion

    #region Vec4 Swizzling
    public Vec4<TNumber> Xxxx
        => new(X, X, X, X);

    public Vec4<TNumber> Xxxy
        => new(X, X, X, Y);

    public Vec4<TNumber> Xxxz
        => new(X, X, X, Z);

    public Vec4<TNumber> Xxxw
        => new(X, X, X, W);

    public Vec4<TNumber> Xxyx
        => new(X, X, Y, X);

    public Vec4<TNumber> Xxyy
        => new(X, X, Y, Y);

    public Vec4<TNumber> Xxyz
        => new(X, X, Y, Z);

    public Vec4<TNumber> Xxyw
        => new(X, X, Y, W);

    public Vec4<TNumber> Xxzx
        => new(X, X, Z, X);

    public Vec4<TNumber> Xxzy
        => new(X, X, Z, Y);

    public Vec4<TNumber> Xxzz
        => new(X, X, Z, Z);

    public Vec4<TNumber> Xxzw
        => new(X, X, Z, W);

    public Vec4<TNumber> Xxwx
        => new(X, X, W, X);

    public Vec4<TNumber> Xxwy
        => new(X, X, W, Y);

    public Vec4<TNumber> Xxwz
        => new(X, X, W, Z);

    public Vec4<TNumber> Xxww
        => new(X, X, W, W);

    public Vec4<TNumber> Xyxx
        => new(X, Y, X, X);

    public Vec4<TNumber> Xyxy
        => new(X, Y, X, Y);

    public Vec4<TNumber> Xyxz
        => new(X, Y, X, Z);

    public Vec4<TNumber> Xyxw
        => new(X, Y, X, W);

    public Vec4<TNumber> Xyyx
        => new(X, Y, Y, X);

    public Vec4<TNumber> Xyyy
        => new(X, Y, Y, Y);

    public Vec4<TNumber> Xyyz
        => new(X, Y, Y, Z);

    public Vec4<TNumber> Xyyw
        => new(X, Y, Y, W);

    public Vec4<TNumber> Xyzx
        => new(X, Y, Z, X);

    public Vec4<TNumber> Xyzy
        => new(X, Y, Z, Y);

    public Vec4<TNumber> Xyzz
        => new(X, Y, Z, Z);

    public Vec4<TNumber> Xyzw
        => new(X, Y, Z, W);

    public Vec4<TNumber> Xywx
        => new(X, Y, W, X);

    public Vec4<TNumber> Xywy
        => new(X, Y, W, Y);

    public Vec4<TNumber> Xywz
        => new(X, Y, W, Z);

    public Vec4<TNumber> Xyww
        => new(X, Y, W, W);

    public Vec4<TNumber> Xzxx
        => new(X, Z, X, X);

    public Vec4<TNumber> Xzxy
        => new(X, Z, X, Y);

    public Vec4<TNumber> Xzxz
        => new(X, Z, X, Z);

    public Vec4<TNumber> Xzxw
        => new(X, Z, X, W);

    public Vec4<TNumber> Xzyx
        => new(X, Z, Y, X);

    public Vec4<TNumber> Xzyy
        => new(X, Z, Y, Y);

    public Vec4<TNumber> Xzyz
        => new(X, Z, Y, Z);

    public Vec4<TNumber> Xzyw
        => new(X, Z, Y, W);

    public Vec4<TNumber> Xzzx
        => new(X, Z, Z, X);

    public Vec4<TNumber> Xzzy
        => new(X, Z, Z, Y);

    public Vec4<TNumber> Xzzz
        => new(X, Z, Z, Z);

    public Vec4<TNumber> Xzzw
        => new(X, Z, Z, W);

    public Vec4<TNumber> Xzwx
        => new(X, Z, W, X);

    public Vec4<TNumber> Xzwy
        => new(X, Z, W, Y);

    public Vec4<TNumber> Xzwz
        => new(X, Z, W, Z);

    public Vec4<TNumber> Xzww
        => new(X, Z, W, W);

    public Vec4<TNumber> Xwxx
        => new(X, W, X, X);

    public Vec4<TNumber> Xwxy
        => new(X, W, X, Y);

    public Vec4<TNumber> Xwxz
        => new(X, W, X, Z);

    public Vec4<TNumber> Xwxw
        => new(X, W, X, W);

    public Vec4<TNumber> Xwyx
        => new(X, W, Y, X);

    public Vec4<TNumber> Xwyy
        => new(X, W, Y, Y);

    public Vec4<TNumber> Xwyz
        => new(X, W, Y, Z);

    public Vec4<TNumber> Xwyw
        => new(X, W, Y, W);

    public Vec4<TNumber> Xwzx
        => new(X, W, Z, X);

    public Vec4<TNumber> Xwzy
        => new(X, W, Z, Y);

    public Vec4<TNumber> Xwzz
        => new(X, W, Z, Z);

    public Vec4<TNumber> Xwzw
        => new(X, W, Z, W);

    public Vec4<TNumber> Xwwx
        => new(X, W, W, X);

    public Vec4<TNumber> Xwwy
        => new(X, W, W, Y);

    public Vec4<TNumber> Xwwz
        => new(X, W, W, Z);

    public Vec4<TNumber> Xwww
        => new(X, W, W, W);

    public Vec4<TNumber> Yxxx
        => new(Y, X, X, X);

    public Vec4<TNumber> Yxxy
        => new(Y, X, X, Y);

    public Vec4<TNumber> Yxxz
        => new(Y, X, X, Z);

    public Vec4<TNumber> Yxxw
        => new(Y, X, X, W);

    public Vec4<TNumber> Yxyx
        => new(Y, X, Y, X);

    public Vec4<TNumber> Yxyy
        => new(Y, X, Y, Y);

    public Vec4<TNumber> Yxyz
        => new(Y, X, Y, Z);

    public Vec4<TNumber> Yxyw
        => new(Y, X, Y, W);

    public Vec4<TNumber> Yxzx
        => new(Y, X, Z, X);

    public Vec4<TNumber> Yxzy
        => new(Y, X, Z, Y);

    public Vec4<TNumber> Yxzz
        => new(Y, X, Z, Z);

    public Vec4<TNumber> Yxzw
        => new(Y, X, Z, W);

    public Vec4<TNumber> Yxwx
        => new(Y, X, W, X);

    public Vec4<TNumber> Yxwy
        => new(Y, X, W, Y);

    public Vec4<TNumber> Yxwz
        => new(Y, X, W, Z);

    public Vec4<TNumber> Yxww
        => new(Y, X, W, W);

    public Vec4<TNumber> Yyxx
        => new(Y, Y, X, X);

    public Vec4<TNumber> Yyxy
        => new(Y, Y, X, Y);

    public Vec4<TNumber> Yyxz
        => new(Y, Y, X, Z);

    public Vec4<TNumber> Yyxw
        => new(Y, Y, X, W);

    public Vec4<TNumber> Yyyx
        => new(Y, Y, Y, X);

    public Vec4<TNumber> Yyyy
        => new(Y, Y, Y, Y);

    public Vec4<TNumber> Yyyz
        => new(Y, Y, Y, Z);

    public Vec4<TNumber> Yyyw
        => new(Y, Y, Y, W);

    public Vec4<TNumber> Yyzx
        => new(Y, Y, Z, X);

    public Vec4<TNumber> Yyzy
        => new(Y, Y, Z, Y);

    public Vec4<TNumber> Yyzz
        => new(Y, Y, Z, Z);

    public Vec4<TNumber> Yyzw
        => new(Y, Y, Z, W);

    public Vec4<TNumber> Yywx
        => new(Y, Y, W, X);

    public Vec4<TNumber> Yywy
        => new(Y, Y, W, Y);

    public Vec4<TNumber> Yywz
        => new(Y, Y, W, Z);

    public Vec4<TNumber> Yyww
        => new(Y, Y, W, W);

    public Vec4<TNumber> Yzxx
        => new(Y, Z, X, X);

    public Vec4<TNumber> Yzxy
        => new(Y, Z, X, Y);

    public Vec4<TNumber> Yzxz
        => new(Y, Z, X, Z);

    public Vec4<TNumber> Yzxw
        => new(Y, Z, X, W);

    public Vec4<TNumber> Yzyx
        => new(Y, Z, Y, X);

    public Vec4<TNumber> Yzyy
        => new(Y, Z, Y, Y);

    public Vec4<TNumber> Yzyz
        => new(Y, Z, Y, Z);

    public Vec4<TNumber> Yzyw
        => new(Y, Z, Y, W);

    public Vec4<TNumber> Yzzx
        => new(Y, Z, Z, X);

    public Vec4<TNumber> Yzzy
        => new(Y, Z, Z, Y);

    public Vec4<TNumber> Yzzz
        => new(Y, Z, Z, Z);

    public Vec4<TNumber> Yzzw
        => new(Y, Z, Z, W);

    public Vec4<TNumber> Yzwx
        => new(Y, Z, W, X);

    public Vec4<TNumber> Yzwy
        => new(Y, Z, W, Y);

    public Vec4<TNumber> Yzwz
        => new(Y, Z, W, Z);

    public Vec4<TNumber> Yzww
        => new(Y, Z, W, W);

    public Vec4<TNumber> Ywxx
        => new(Y, W, X, X);

    public Vec4<TNumber> Ywxy
        => new(Y, W, X, Y);

    public Vec4<TNumber> Ywxz
        => new(Y, W, X, Z);

    public Vec4<TNumber> Ywxw
        => new(Y, W, X, W);

    public Vec4<TNumber> Ywyx
        => new(Y, W, Y, X);

    public Vec4<TNumber> Ywyy
        => new(Y, W, Y, Y);

    public Vec4<TNumber> Ywyz
        => new(Y, W, Y, Z);

    public Vec4<TNumber> Ywyw
        => new(Y, W, Y, W);

    public Vec4<TNumber> Ywzx
        => new(Y, W, Z, X);

    public Vec4<TNumber> Ywzy
        => new(Y, W, Z, Y);

    public Vec4<TNumber> Ywzz
        => new(Y, W, Z, Z);

    public Vec4<TNumber> Ywzw
        => new(Y, W, Z, W);

    public Vec4<TNumber> Ywwx
        => new(Y, W, W, X);

    public Vec4<TNumber> Ywwy
        => new(Y, W, W, Y);

    public Vec4<TNumber> Ywwz
        => new(Y, W, W, Z);

    public Vec4<TNumber> Ywww
        => new(Y, W, W, W);

    public Vec4<TNumber> Zxxx
        => new(Z, X, X, X);

    public Vec4<TNumber> Zxxy
        => new(Z, X, X, Y);

    public Vec4<TNumber> Zxxz
        => new(Z, X, X, Z);

    public Vec4<TNumber> Zxxw
        => new(Z, X, X, W);

    public Vec4<TNumber> Zxyx
        => new(Z, X, Y, X);

    public Vec4<TNumber> Zxyy
        => new(Z, X, Y, Y);

    public Vec4<TNumber> Zxyz
        => new(Z, X, Y, Z);

    public Vec4<TNumber> Zxyw
        => new(Z, X, Y, W);

    public Vec4<TNumber> Zxzx
        => new(Z, X, Z, X);

    public Vec4<TNumber> Zxzy
        => new(Z, X, Z, Y);

    public Vec4<TNumber> Zxzz
        => new(Z, X, Z, Z);

    public Vec4<TNumber> Zxzw
        => new(Z, X, Z, W);

    public Vec4<TNumber> Zxwx
        => new(Z, X, W, X);

    public Vec4<TNumber> Zxwy
        => new(Z, X, W, Y);

    public Vec4<TNumber> Zxwz
        => new(Z, X, W, Z);

    public Vec4<TNumber> Zxww
        => new(Z, X, W, W);

    public Vec4<TNumber> Zyxx
        => new(Z, Y, X, X);

    public Vec4<TNumber> Zyxy
        => new(Z, Y, X, Y);

    public Vec4<TNumber> Zyxz
        => new(Z, Y, X, Z);

    public Vec4<TNumber> Zyxw
        => new(Z, Y, X, W);

    public Vec4<TNumber> Zyyx
        => new(Z, Y, Y, X);

    public Vec4<TNumber> Zyyy
        => new(Z, Y, Y, Y);

    public Vec4<TNumber> Zyyz
        => new(Z, Y, Y, Z);

    public Vec4<TNumber> Zyyw
        => new(Z, Y, Y, W);

    public Vec4<TNumber> Zyzx
        => new(Z, Y, Z, X);

    public Vec4<TNumber> Zyzy
        => new(Z, Y, Z, Y);

    public Vec4<TNumber> Zyzz
        => new(Z, Y, Z, Z);

    public Vec4<TNumber> Zyzw
        => new(Z, Y, Z, W);

    public Vec4<TNumber> Zywx
        => new(Z, Y, W, X);

    public Vec4<TNumber> Zywy
        => new(Z, Y, W, Y);

    public Vec4<TNumber> Zywz
        => new(Z, Y, W, Z);

    public Vec4<TNumber> Zyww
        => new(Z, Y, W, W);

    public Vec4<TNumber> Zzxx
        => new(Z, Z, X, X);

    public Vec4<TNumber> Zzxy
        => new(Z, Z, X, Y);

    public Vec4<TNumber> Zzxz
        => new(Z, Z, X, Z);

    public Vec4<TNumber> Zzxw
        => new(Z, Z, X, W);

    public Vec4<TNumber> Zzyx
        => new(Z, Z, Y, X);

    public Vec4<TNumber> Zzyy
        => new(Z, Z, Y, Y);

    public Vec4<TNumber> Zzyz
        => new(Z, Z, Y, Z);

    public Vec4<TNumber> Zzyw
        => new(Z, Z, Y, W);

    public Vec4<TNumber> Zzzx
        => new(Z, Z, Z, X);

    public Vec4<TNumber> Zzzy
        => new(Z, Z, Z, Y);

    public Vec4<TNumber> Zzzz
        => new(Z, Z, Z, Z);

    public Vec4<TNumber> Zzzw
        => new(Z, Z, Z, W);

    public Vec4<TNumber> Zzwx
        => new(Z, Z, W, X);

    public Vec4<TNumber> Zzwy
        => new(Z, Z, W, Y);

    public Vec4<TNumber> Zzwz
        => new(Z, Z, W, Z);

    public Vec4<TNumber> Zzww
        => new(Z, Z, W, W);

    public Vec4<TNumber> Zwxx
        => new(Z, W, X, X);

    public Vec4<TNumber> Zwxy
        => new(Z, W, X, Y);

    public Vec4<TNumber> Zwxz
        => new(Z, W, X, Z);

    public Vec4<TNumber> Zwxw
        => new(Z, W, X, W);

    public Vec4<TNumber> Zwyx
        => new(Z, W, Y, X);

    public Vec4<TNumber> Zwyy
        => new(Z, W, Y, Y);

    public Vec4<TNumber> Zwyz
        => new(Z, W, Y, Z);

    public Vec4<TNumber> Zwyw
        => new(Z, W, Y, W);

    public Vec4<TNumber> Zwzx
        => new(Z, W, Z, X);

    public Vec4<TNumber> Zwzy
        => new(Z, W, Z, Y);

    public Vec4<TNumber> Zwzz
        => new(Z, W, Z, Z);

    public Vec4<TNumber> Zwzw
        => new(Z, W, Z, W);

    public Vec4<TNumber> Zwwx
        => new(Z, W, W, X);

    public Vec4<TNumber> Zwwy
        => new(Z, W, W, Y);

    public Vec4<TNumber> Zwwz
        => new(Z, W, W, Z);

    public Vec4<TNumber> Zwww
        => new(Z, W, W, W);

    public Vec4<TNumber> Wxxx
        => new(W, X, X, X);

    public Vec4<TNumber> Wxxy
        => new(W, X, X, Y);

    public Vec4<TNumber> Wxxz
        => new(W, X, X, Z);

    public Vec4<TNumber> Wxxw
        => new(W, X, X, W);

    public Vec4<TNumber> Wxyx
        => new(W, X, Y, X);

    public Vec4<TNumber> Wxyy
        => new(W, X, Y, Y);

    public Vec4<TNumber> Wxyz
        => new(W, X, Y, Z);

    public Vec4<TNumber> Wxyw
        => new(W, X, Y, W);

    public Vec4<TNumber> Wxzx
        => new(W, X, Z, X);

    public Vec4<TNumber> Wxzy
        => new(W, X, Z, Y);

    public Vec4<TNumber> Wxzz
        => new(W, X, Z, Z);

    public Vec4<TNumber> Wxzw
        => new(W, X, Z, W);

    public Vec4<TNumber> Wxwx
        => new(W, X, W, X);

    public Vec4<TNumber> Wxwy
        => new(W, X, W, Y);

    public Vec4<TNumber> Wxwz
        => new(W, X, W, Z);

    public Vec4<TNumber> Wxww
        => new(W, X, W, W);

    public Vec4<TNumber> Wyxx
        => new(W, Y, X, X);

    public Vec4<TNumber> Wyxy
        => new(W, Y, X, Y);

    public Vec4<TNumber> Wyxz
        => new(W, Y, X, Z);

    public Vec4<TNumber> Wyxw
        => new(W, Y, X, W);

    public Vec4<TNumber> Wyyx
        => new(W, Y, Y, X);

    public Vec4<TNumber> Wyyy
        => new(W, Y, Y, Y);

    public Vec4<TNumber> Wyyz
        => new(W, Y, Y, Z);

    public Vec4<TNumber> Wyyw
        => new(W, Y, Y, W);

    public Vec4<TNumber> Wyzx
        => new(W, Y, Z, X);

    public Vec4<TNumber> Wyzy
        => new(W, Y, Z, Y);

    public Vec4<TNumber> Wyzz
        => new(W, Y, Z, Z);

    public Vec4<TNumber> Wyzw
        => new(W, Y, Z, W);

    public Vec4<TNumber> Wywx
        => new(W, Y, W, X);

    public Vec4<TNumber> Wywy
        => new(W, Y, W, Y);

    public Vec4<TNumber> Wywz
        => new(W, Y, W, Z);

    public Vec4<TNumber> Wyww
        => new(W, Y, W, W);

    public Vec4<TNumber> Wzxx
        => new(W, Z, X, X);

    public Vec4<TNumber> Wzxy
        => new(W, Z, X, Y);

    public Vec4<TNumber> Wzxz
        => new(W, Z, X, Z);

    public Vec4<TNumber> Wzxw
        => new(W, Z, X, W);

    public Vec4<TNumber> Wzyx
        => new(W, Z, Y, X);

    public Vec4<TNumber> Wzyy
        => new(W, Z, Y, Y);

    public Vec4<TNumber> Wzyz
        => new(W, Z, Y, Z);

    public Vec4<TNumber> Wzyw
        => new(W, Z, Y, W);

    public Vec4<TNumber> Wzzx
        => new(W, Z, Z, X);

    public Vec4<TNumber> Wzzy
        => new(W, Z, Z, Y);

    public Vec4<TNumber> Wzzz
        => new(W, Z, Z, Z);

    public Vec4<TNumber> Wzzw
        => new(W, Z, Z, W);

    public Vec4<TNumber> Wzwx
        => new(W, Z, W, X);

    public Vec4<TNumber> Wzwy
        => new(W, Z, W, Y);

    public Vec4<TNumber> Wzwz
        => new(W, Z, W, Z);

    public Vec4<TNumber> Wzww
        => new(W, Z, W, W);

    public Vec4<TNumber> Wwxx
        => new(W, W, X, X);

    public Vec4<TNumber> Wwxy
        => new(W, W, X, Y);

    public Vec4<TNumber> Wwxz
        => new(W, W, X, Z);

    public Vec4<TNumber> Wwxw
        => new(W, W, X, W);

    public Vec4<TNumber> Wwyx
        => new(W, W, Y, X);

    public Vec4<TNumber> Wwyy
        => new(W, W, Y, Y);

    public Vec4<TNumber> Wwyz
        => new(W, W, Y, Z);

    public Vec4<TNumber> Wwyw
        => new(W, W, Y, W);

    public Vec4<TNumber> Wwzx
        => new(W, W, Z, X);

    public Vec4<TNumber> Wwzy
        => new(W, W, Z, Y);

    public Vec4<TNumber> Wwzz
        => new(W, W, Z, Z);

    public Vec4<TNumber> Wwzw
        => new(W, W, Z, W);

    public Vec4<TNumber> Wwwx
        => new(W, W, W, X);

    public Vec4<TNumber> Wwwy
        => new(W, W, W, Y);

    public Vec4<TNumber> Wwwz
        => new(W, W, W, Z);

    public Vec4<TNumber> Wwww
        => new(W, W, W, W);
    #endregion
}