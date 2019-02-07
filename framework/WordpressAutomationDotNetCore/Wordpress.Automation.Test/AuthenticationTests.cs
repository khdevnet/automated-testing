using NUnit.Allure.Core;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Workflows;

namespace Wordpress.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class AuthenticationTests : WordpressBaseTest
    {
        [Test]
        public void Admin_User_Can_LogIn()
        {
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }

        [Test]
        public void Admin_User_Can_LogOut()
        {
            AuthenticationFlow.LogOut();
            Assert.IsTrue(LoginPage.IsAt, "Failed to login.");
        }
    }
}
