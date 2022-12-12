using AuditImportService.Data.Repositories;
using AuditImportService.Import.Parsers;
using AuditImportService.Middleware;
using AuditImportService.Services;

namespace AuditImportService.Configuration;

public static class CustomConfigurationBuilder
{
    public static void BuildCustomRequiredDependencies(this WebApplicationBuilder builder)
    {
        ConfigureSettings(builder);
        ConfigureRepositories(builder.Services);
        ConfigureParsers(builder.Services);
        ConfigureServices(builder.Services);
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddTransient<StatusService>();
    }
    private static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddTransient<ErrorRepository>();
        services.AddTransient<TrafficLogRepository>();
        services.AddTransient<FirewallDateRepository>();
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
    
}