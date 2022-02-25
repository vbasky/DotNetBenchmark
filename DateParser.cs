namespace DotNetBenchmark;
public class DateParser
{
    public static int GetYearFromDate(string dateTimeAsString)
    {
        var dateTime = DateTime.Parse(dateTimeAsString);
        return dateTime.Year;
    }

    public static int GetYearFromSplit(string dateTimeAsString)
    {
        var dateTime = dateTimeAsString.Split('-');
        return int.Parse(dateTime[0]);
    }

    public static int GetYearFromSubString(string dateTimeAsString)
    {
        var indexOfHyphen = dateTimeAsString.IndexOf('-');
        return int.Parse(dateTimeAsString.Substring(0, indexOfHyphen));
    }

    public static int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfHyphen = dateTimeAsSpan.IndexOf('-');
        return int.Parse(dateTimeAsSpan.Slice(0, indexOfHyphen));
    }

    public static int GetYearFromManualConversion(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfHyphen = dateTimeAsSpan.IndexOf('-');
        var yearAsASpan = dateTimeAsSpan.Slice(0, indexOfHyphen);
        var temp = 0;
        foreach (var t in yearAsASpan)
        {
            temp = 10 * temp + (t - '0');
        }
        return temp;
    }
}