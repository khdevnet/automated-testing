using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Test;

namespace Wordpress.Tests.Smoke
{
    [TestFixture]
    [AllureFeature(Features.WordpressSmokeTests)]
    public class PageTests : WordpressBaseTest
    {
        [Test]
        [TestCase(TestName = nameof(Can_Edit_A_Page))]
        public void Can_Edit_A_Page()
        {
            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }
    }
}
