using Automation.Framework.Core.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Wordpress.Automation.Framework.Navigation;
using Wordpress.Automation.Framework.Pages;

namespace Wordpress.Automation.Framework.Workflows
{
    public class AuthenticationFlow
    {
        public static void LogIn()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(UserSettings.UserName).WithPassword(UserSettings.Password).Login();
            IsAuthenticated = true;
        }

        public static void LogOut()
        {
            LeftNavigation.Dashboard.Select();
            Actions action = new Actions(Driver.Instance);
            IWebElement we = Driver.Instance.FindElement(By.Id("wp-admin-bar-my-account"));
            action.MoveToElement(we).Build().Perform();
            Driver.Instance.FindElement(By.XPath("//li[@id='wp-admin-bar-logout']//a")).Click();

            IsAuthenticated = false;
        }

        public static bool IsAuthenticated { get; private set; }
    }
}
