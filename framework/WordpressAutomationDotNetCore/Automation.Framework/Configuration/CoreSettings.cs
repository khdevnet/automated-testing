namespace Automation.Framework.Core
{
    public class CoreSettings
    {
        private CoreSettings()
        {

        }

        static CoreSettings()
        {
            WebdriverPath = ConfigurationProvider.Configurations.GetSection("webdriverPath").Value;
            Hostname = ConfigurationProvider.Configurations.GetSection("hostname").Value;
            var headless = ConfigurationProvider.Configurations.GetSection("headless").Value;
            IsHeadless = !string.IsNullOrEmpty(headless) && headless.ToLower() == "true";
        }

        public static bool IsHeadless { get; private set; }
        public static string WebdriverPath { get; private set; }
        public static string Hostname { get; private set; }
    }
}
