namespace AuditResolution.Common.Extensions;

public static class DatetimeExtensions
{
    public static DateTime ToStartOfDay(this DateTime sourceDate)
    {
        return new DateTime(sourceDate.Year, sourceDate.Month, sourceDate.Day, 0, 0, 0, 0);
    }
    
    public static DateTime ToEndOfDay(this DateTime sourceDate)
    {
        return new DateTime(sourceDate.Year, sourceDate.Month, sourceDate.Day, 23, 59, 59, 999);
    }

    public static DateTime NextDay(this DateTime sourceDate)
    {
        return sourceDate.Add(new TimeSpan(1, 0, 0, 0));
    }
}