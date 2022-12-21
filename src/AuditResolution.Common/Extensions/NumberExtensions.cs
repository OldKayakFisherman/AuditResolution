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
    
    public static short ToDefaultShort(this string? sourceValue)
    {
        short retval = 0;
        short parseOut = 0;
        
        if (short.TryParse(sourceValue, out parseOut))
        {
            retval = parseOut;
        }
        
        return retval;
    }
}