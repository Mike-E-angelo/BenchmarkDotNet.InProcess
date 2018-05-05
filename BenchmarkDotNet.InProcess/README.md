# BenchmarkDotNet.InProcess

### First Run (no `BenchmarkDotNet.Artifacts` folder)

```
// * Summary *

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.14393.2189 (1607/AnniversaryUpdate/Redstone1)
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3613269 Hz, Resolution=276.7577 ns, Timer=TSC
.NET Core SDK=2.1.300-preview2-008533
  [Host] : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT

Job=InProcess  Toolchain=InProcessToolchain

  Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
-------- |---------:|----------:|----------:|-------:|-------:|----------:|
 ToArray | 21.82 us | 0.8184 us | 0.2126 us | 7.6294 | 0.8240 |  39.13 KB |
```

### Second Run (with `BenchmarkDotNet.Artifacts` folder)

```
  Method |     Mean |    Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
-------- |---------:|---------:|----------:|-------:|-------:|----------:|
 ToArray | 19.42 us | 1.285 us | 0.3338 us | 7.6294 | 0.8240 |  39.13 KB |
```