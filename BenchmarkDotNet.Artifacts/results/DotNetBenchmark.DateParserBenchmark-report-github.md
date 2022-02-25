``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.2.1 (21D62) [Darwin 21.3.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|                          Method |       Mean |     Error |    StdDev | Ratio | Rank |  Gen 0 | Allocated |
|-------------------------------- |-----------:|----------:|----------:|------:|-----:|-------:|----------:|
| GetYearFromSpanManualConversion |   6.356 ns | 0.1555 ns | 0.3247 ns |  0.02 |    1 |      - |         - |
|                 GetYearFromSpan |  19.065 ns | 0.5113 ns | 1.4588 ns |  0.06 |    2 |      - |         - |
|            GetYearFromSubString |  29.405 ns | 0.6079 ns | 0.7905 ns |  0.09 |    3 | 0.0038 |      32 B |
|                GetYearFromSplit |  75.458 ns | 0.9592 ns | 0.8972 ns |  0.23 |    4 | 0.0191 |     160 B |
|             GetYearFromDateTime | 326.446 ns | 2.0527 ns | 1.8197 ns |  1.00 |    5 |      - |         - |
