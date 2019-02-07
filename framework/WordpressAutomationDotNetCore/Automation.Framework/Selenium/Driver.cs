using System;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.Framework.Core.Selenium
{
    public class Driver
    {
        public static IWebDriver Instance { get; private set; }

        public static string BaseAddress = CoreSettings.Hostname;

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            if (CoreSettings.IsHeadless)
            {
                options.AddArguments("headless");
            }

            Instance = new ChromeDriver(CoreSettings.WebdriverPath, options);

            Instance.Manage().Window.Size = new Size(1024, 768);
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        public static void NoWait(Action action)
        {
            TurnOffWait();
            action();
            TurnOnWait();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}