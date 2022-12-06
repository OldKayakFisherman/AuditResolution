using AuditImportService.Middleware;

namespace AuditImportService.Configuration;

public static class MiddlewareConfigurationBuilder
{
    public static void ConfigureCustomMiddleware(this IApplicationBuilder builder)
    {
        //Custom Middleware
        builder.UseErrorHandlerMiddleware();
        builder.UseTrafficLoggerMiddleware();
    }
}