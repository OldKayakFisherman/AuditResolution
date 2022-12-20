namespace AuditResolution.Common.Extensions;

public static class NumberExtensions
{
    public static int ToDefaultInt(this string? sourceValue)
    {
        int retval = 0;
        int parseOut = 0;
        
        if (int.TryParse(sourceValue, out parseOut))
        {
            retval = parseOut;
        }
        
        return retval;
    }
}