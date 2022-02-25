using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace DotNetBenchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]

public class DateParserBenchmark
{
    private const string DateTime = "2019-01-01T00:00:00Z";
    private static readonly DateParser DateParser = new DateParser();

    [Benchmark(Baseline = true)]
    public void GetYearFromDateTime()
    {
        DateParser.GetYearFromDate(DateTime);
    }

    [Benchmark]
    public void GetYearFromSplit()
    {
        DateParser.GetYearFromSplit(DateTime);
    }

    [Benchmark]
    public void GetYearFromSubString()
    {
        DateParser.GetYearFromSubString(DateTime);
    }

    [Benchmark]
    public void GetYearFromSpan()
    {
        DateParser.GetYearFromSpan(DateTime);
    }

    [Benchmark]
    public void GetYearFromSpanManualConversion()
    {
        DateParser.GetYearFromManualConversion(DateTime);
    }
}