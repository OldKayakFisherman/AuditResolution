using AuditImportService.Data.Repositories;
using AuditImportService.Import.Parsers;
using AuditImportService.Middleware;

namespace AuditImportService.Configuration;

public static class CustomConfigurationBuilder
{
    public static void BuildCustomRequiredDependencies(this WebApplicationBuilder builder)
    {
        ConfigureSettings(builder);
        ConfigureRepositories(builder.Services);
        ConfigureParsers(builder.Services);
    }

    private static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddTransient<ErrorRepository>();
    }
    
    private static void ConfigureParsers(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddTransient<DBKeyParser>();
    }
    
    private static void ConfigureSettings(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<AppSettings>(
            builder.Configuration.GetSection("AppSettings")
        );
    }

    public static void ConfigureCustomMiddleware(this IApplicationBuilder builder)
    {
        builder.UseErrorHandlerMiddleware();
    }
}