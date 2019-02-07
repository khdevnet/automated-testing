using System.IO;
using Microsoft.Extensions.Configuration;

namespace Automation.Framework.Core
{
    public class ConfigurationProvider
    {
        static ConfigurationProvider()
        {
            Configurations = CreateConfiguration();
        }

        public static IConfiguration Configurations { get; private set; }

        private static IConfiguration CreateConfiguration()
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = configBuilder.Build();

            return configuration;
        }
    }
}
