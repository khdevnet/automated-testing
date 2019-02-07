using System;
using Automation.Framework.Core.Selenium;
using OpenQA.Selenium;

namespace Wordpress.Automation.Framework.Pages
{
    public class LoginPage : PageBase
    {
        public static bool IsAt => Driver.Instance.FindElements(By.Id("login")).Count > 0;

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl($"{Driver.BaseAddress}/wp-login.php");
            Driver.Wait(TimeSpan.FromSeconds(1));
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("user_login"));
            loginInput.Clear();
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.Clear();
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            loginButton.Click();
        }
    }
}
