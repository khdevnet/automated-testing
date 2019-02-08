using NUnit.Allure.Attributes;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages.Pages;
using Wordpress.Automation.Framework.Workflows;
using Wordpress.Tests;

namespace Wordpress.Automation.Test.Posts
{
    [TestFixture]
    [AllureFeature(Features.WordpressPages)]
    public class PagesTests : WordpressBaseTest
    {
        [Test]
        public void Can_Search_Pages()
        {
            PageCreator.CreatePage();
            ListPagesPage.SearchForPage(PageCreator.PreviousTitle);
            Assert.IsTrue(ListPagesPage.DoesPostExistWithTitle(PageCreator.PreviousTitle));
            PageCreator.Cleanup();
        }
    }
}
