using BenchmarkDotNet.Running;

namespace DotNetBenchmark;

public static class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<DateParserBenchmark>();
        BenchmarkRunner.Run<StringBenchmark>();
    }
}