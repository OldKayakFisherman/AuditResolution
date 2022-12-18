namespace AuditResolution.Common.Extensions;

public static class BooleanExtensions
{
    public static bool ConvertFromYNString(this string? input)
    {
        var retval = false;

        if (input != null)
        {
            retval = input.ToUpper() == "Y";
        }

        return retval;
    }
}