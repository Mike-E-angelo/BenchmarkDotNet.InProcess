# BenchmarkDotNet.InProcess

## .NET Core 2.0

```
// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-4650U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240905 Hz, Resolution=446.2483 ns, Timer=TSC
  [Host] : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=5
WarmupCount=5

  Method |     Mean |     Error |    StdDev |   Gen 0 | Allocated |
-------- |---------:|----------:|----------:|--------:|----------:|
 ToArray | 24.75 us | 0.9117 us | 0.2368 us | 18.8599 |  39.13 KB |
```

## .NET Core 2.1

```
// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-4650U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240905 Hz, Resolution=446.2483 ns, Timer=TSC
  [Host] : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

Toolchain=InProcessToolchain  LaunchCount=1  TargetCount=5
WarmupCount=5

  Method |     Mean |    Error |    StdDev |   Gen 0 | Allocated |
-------- |---------:|---------:|----------:|--------:|----------:|
 ToArray | 21.42 us | 1.305 us | 0.3390 us | 18.8599 |  39.13 KB |
```