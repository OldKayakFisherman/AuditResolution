
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace TestHelpers
{
    public static class AppSettingsHelper
    {
        
        /// <summary>
        /// Returns a settings object from the specified file with a key
        /// </summary>
        /// <param name="settingsFile"></param>
        /// <param name="settingsKey"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <remarks>Settings File must have a value associated</remarks>
        public static T? GetAppSettings<T>(string settingsFile, string settingsKey)
        {
            var settings = default(T);
            
            var configDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (configDir != null)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath( configDir)
                    .AddJsonFile(settingsFile, optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .AddUserSecrets(Assembly.GetCallingAssembly(),false);

                IConfiguration config = builder.Build();

                settings = config.GetRequiredSection(settingsKey).Get<T>();
            }

            return settings;
            
        }
        
    }
}