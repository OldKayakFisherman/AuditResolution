using AuditImportService.Import.Parsers;

namespace AuditImportService.Configuration;

public static class CustomConfigurationBuilder
{
    public static void BuildCustomRequiredDependencies(this WebApplicationBuilder builder)
    {
        ConfigureSettings(builder);  
        ConfigureParsers(builder.Services);
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