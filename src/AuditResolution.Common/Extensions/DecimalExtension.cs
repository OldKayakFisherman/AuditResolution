namespace AuditResolution.Common.Extensions;

public static class DecimalExtension
{
    public static Decimal ToMoney(this string? sourceValue)
    {
        Decimal retval = Decimal.Zero;
        Decimal parseOut = Decimal.Zero;
        
        if (Decimal.TryParse(sourceValue, out parseOut))
        {
            retval = parseOut;
        }
        
        return retval;
    }
}