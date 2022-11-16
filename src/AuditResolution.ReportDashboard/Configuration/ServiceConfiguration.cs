using AuditResolution.Infrastructure.Configuration;
using AuditResolution.Infrastructure.Import.Parsers;

namespace AuditResolution.ReportDashboard.Configuration
{
    public static class ServiceConfiguration
    {
        public static void ConfigureRequiredDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.ConfigureDataRepositories();
            builder.Services.ConfigureUtilities();
            builder.Services.ConfigureLocalServices();
            builder.ConfigureSettings();
        }

        private static void ConfigureParsers(this WebApplicationBuilder builder)
        {
            builder.AddHttpClient();
            services.AddTransient<DbKeyParser>();
        }

        private static void ConfigureSettings(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<AppSettings>(
                builder.Configuration.GetSection("AppSettings")
            );
        }

        private static void ConfigureDataRepositories(this IServiceCollection services)
        {
            
        }

        private static void ConfigureUtilities(this IServiceCollection services)
        {
            
        }

        private static void ConfigureLocalServices(this IServiceCollection services)
        {
           

        }
    }
}
