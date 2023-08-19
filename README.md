
<p align="center">
    <img src="https://raw.githubusercontent.com/GasInfinity/Rena.Mathematics/main/assets/logo-math.svg" height="130">
</p>

<h1 align="center"> Rena.Mathematics</h1>

<p align="center">
    <a href="https://dotnet.microsoft.com/"><img alt="Dynamic XML Badge" src="https://img.shields.io/badge/dynamic/xml?url=https%3A%2F%2Fraw.githubusercontent.com%2FGasInfinity%2FRena.Mathematics%2Fmain%2FRena.Mathematics%2FRena.Mathematics.csproj&query=%2F%2FTargetFramework%5B1%5D&logo=dotnet&logoColor=green&label=%20&color=222222"></a>
    <a href="https://www.codefactor.io/repository/github/gasinfinity/rena.mathematics"><img src="https://www.codefactor.io/repository/github/gasinfinity/rena.mathematics/badge" alt="CodeFactor" /></a>
    <a href="https://www.nuget.org/packages/Rena.Mathematics/"><img alt="Nuget" src="https://img.shields.io/nuget/v/Rena.Mathematics"></a>
    <a href="https://mit-license.org/"><img alt="GitHub" src="https://img.shields.io/github/license/GasInfinity/Rena.Mathematics"></a>
</p>

> Warning! This library is in development and currently does not adhere to SemVer until we hit v2.0, so, expect breaking changes!

## Features
* Generic abstraction for [Radians{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Radians{T}.cs) and [Degrees{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Degrees{T}.cs)
* Multiple generic vector types like [Vec2{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Vectors/Vec2{T}.cs) and [Vec3{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Vectors/Vec3{T}.cs)
* Multiple generic matrix types like [Mat4x4{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Matrices/Mat4x4{T}.cs)
* High-performance SIMD optimizations where applicable

## Why use this library instead of System.Numerics?
* This library uses generic math so you're not limited to only `System.Single`
* Tries be as optimized as possible with SIMD instructions thanks to `System.Runtime.Intrinsics` and the new `Unsafe.BitCast` of .NET 8 🚀
  * In this moment Vec3 does not have SIMD support implemented
  * This library can't do magic, the JIT its what does all the work for us. The generated assembly of the JIT is partially optimal for [Vec4{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Vectors/Vec4{T}.cs) in win-x64 and win-x86, other types or RID's may not be as optimal as they should be ✏️
## When to stick with System.Numerics
* When you only need Vectors with `System.Single`. Those vectors are handled specially by the runtime so you won't have any problem with them, so, unless we have something specific you need, you don't need Rena.Mathematics
* When you can't update to _.NET 8_ (This limitiation is a temporal measure)

## TODO's
- [ ] Support .NET 7 without SIMD? (We don't have Unsafe.BitCast there, so, conditional compilation...)
- [ ] Finish [Quat{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Quat{T}.cs) implementation 
- [ ] Add all the remaining MatMxN types
- [ ] [Vec3{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Vectors/Vec3{T}.cs) SIMD
- [ ] v2.0