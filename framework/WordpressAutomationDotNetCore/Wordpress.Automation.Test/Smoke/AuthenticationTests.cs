using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Workflows;
using Wordpress.Automation.Test;

namespace Wordpress.Tests
{
    [TestFixture]
    [AllureFeature(Features.WordpressSmokeTests)]
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
