using Microsoft.Extensions.Http;

namespace AuditResolution.ReportDashboard.Configuration
{
    public static class ServiceConfiguration
    {
        public static void ConfigureRequiredDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.ConfigureDataRepositories();
            builder.Services.ConfigureUtilities();
            builder.Services.ConfigureLocalServices();
            builder.Services.ConfigureParsers();
            builder.ConfigureSettings();
            
        }

        private static void ConfigureParsers(this IServiceCollection services)
        {
            services.AddHttpClient();
            
        }

        private static void ConfigureSettings(this WebApplicationBuilder builder)
        {
           
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
