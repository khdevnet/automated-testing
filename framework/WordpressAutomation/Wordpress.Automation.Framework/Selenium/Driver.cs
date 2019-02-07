using System;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Wordpress.Automation.Framework.Selenium
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public const string BaseAddress = "http://localhost:8090";

        public static void Initialize()
        {
            Instance = new ChromeDriver(@"C:\projects\automated-testing\framework\WordpressAutomation\tools\");
            Instance.Manage().Window.Size = new Size(1024, 768);
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
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
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}