
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

## Features
* Generic abstraction for [Radians{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Radians{T}.cs) and [Degrees{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Degrees{T}.cs)
* Multiple generic vector types like [Vec2{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Vectors/Vec2{T}.cs) and [Vec3{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Vectors/Vec3{T}.cs)
* Multiple generic matrix types like [Mat4x4{T}](https://github.com/GasInfinity/Rena.Mathematics/blob/main/Rena.Mathematics/Matrices/Mat4x4{T}.cs)

## Why use this library instead of System.Numerics?
* This library uses generic math so you're not limited to only `System.Single`
* ^ Basically that. After a lot of research, I've seen that if you want SIMD, just use a data oriented design. The CPU will thank you for doing it.

## When to stick with System.Numerics
* When you only need Vectors with `System.Single`. Those vectors are handled specially by the runtime so you won't have any problem with them, so, unless we have something specific you need, you don't need Rena.Mathematics.

## TODO's
- [ ] Add all the remaining MatMxN types