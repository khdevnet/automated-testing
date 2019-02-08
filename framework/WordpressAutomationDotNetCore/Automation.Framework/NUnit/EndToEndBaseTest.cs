using System;
using System.IO;
using Allure.Commons;
using Automation.Framework.Core.Selenium;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Automation.Framework.Core.NUnit
{
    [AllureNUnit]
    public abstract class EndToEndBaseTest
    {
        [SetUp]
        public virtual void Init()
        {
            Driver.Initialize();
        }

        [TearDown]
        public virtual void Cleanup()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string testName = TestContext.CurrentContext.Test.Name;
                string path = AllureLifecycle.Instance.AllureConfiguration.Directory + "/screens/";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
                var screenshot = ((ITakesScreenshot)Driver.Instance).GetScreenshot();
                var screenshotPath = $"{path}{timestamp}_{testName}.png";
                screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
                AllureLifecycle.Instance.AddAttachment(screenshotPath);
            }
            Driver.Close();
        }
    }

}
