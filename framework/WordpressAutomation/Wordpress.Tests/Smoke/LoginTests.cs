using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.Automation.Framework;
using Wordpress.Automation.Framework.Pages;

namespace Wordpress.Tests.Smoke
{
    [TestClass]
    public class LoginTests : WordpressBaseTest
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }
    }
}
