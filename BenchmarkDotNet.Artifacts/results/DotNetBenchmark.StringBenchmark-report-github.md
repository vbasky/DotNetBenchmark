``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.2.1 (21D62) [Darwin 21.3.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev | Rank |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
|-------------------------------- |----------:|----------:|----------:|-----:|----------:|----------:|---------:|----------:|
| ConcatStringsUsingStringBuilder |  5.544 ms | 0.1023 ms | 0.0957 ms |    1 | 2250.0000 | 1500.0000 | 968.7500 |     15 MB |
|   ConcatStringsUsingGenericList | 16.775 ms | 0.3340 ms | 0.8319 ms |    2 | 1187.5000 |  562.5000 | 250.0000 |      9 MB |
