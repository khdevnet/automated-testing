using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.Automation.Framework;
using Wordpress.Automation.Framework.Pages;

namespace Wordpress.Tests.Smoke
{
    [TestClass]
    public class PageTests : WordpressBaseTest
    {
        [TestMethod]
        public void Can_Edit_A_Page()
        {
            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }
    }
}
