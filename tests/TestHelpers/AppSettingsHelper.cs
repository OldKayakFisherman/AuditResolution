using AuditResolution.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace TestHelpers
{
    public static class AppSettingsHelper
    {
        public static AppSettings? GetAppSettings(string settingsFile)
        {       
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFile, optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddUserSecrets(Assembly.GetCallingAssembly(),false);

            IConfiguration config = builder.Build();

            AppSettings? settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();

            return settings;
        }

    }
}