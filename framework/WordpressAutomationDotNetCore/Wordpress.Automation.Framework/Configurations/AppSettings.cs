using Automation.Framework.Core;

namespace Wordpress.Automation.Framework
{
    public class UserSettings
    {
        private UserSettings()
        {

        }

        static UserSettings()
        {
            UserName = ConfigurationProvider.Configurations.GetSection("user:username").Value;
            Password = ConfigurationProvider.Configurations.GetSection("user:password").Value;
        }
        public static string UserName { get; set; }
        public static string Password { get; set; }
    }
}
