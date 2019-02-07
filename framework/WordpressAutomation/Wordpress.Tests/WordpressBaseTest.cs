using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Selenium;
using Wordpress.Automation.Framework.Workflows;

namespace Wordpress.Tests
{
    public abstract class WordpressBaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            PostCreator.Initialize();

            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("123456").Login();
        }

        [TestCleanup]
        public void Cleanup()
        {
            PostCreator.Cleanup();
            Driver.Close();
        }
    }
}
