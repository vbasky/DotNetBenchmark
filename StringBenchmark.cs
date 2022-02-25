using System.Text;
using BenchmarkDotNet.Attributes;

namespace DotNetBenchmark;

[MemoryDiagnoser]
[RankColumn]
public class StringBenchmark
{
    private const int NumberOfItems = 100000;
        
    [Benchmark]
    public string ConcatStringsUsingStringBuilder()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < NumberOfItems; i++)
        {
            sb.Append("Hello World!" + i);
        }
        return sb.ToString();
    }
    [Benchmark]
    public string? ConcatStringsUsingGenericList()
    {
        var list = new List<string>(NumberOfItems);
        for (var i = 0; i < NumberOfItems; i++)
        {
            list.Add("Hello World!" + i);
        }
        return list.ToString();
    }
}