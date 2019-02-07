using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Workflows;

namespace Wordpress.Tests.Posts
{
    [TestClass]
    public class AllPostsTests : WordpressBaseTest
    {
        [TestMethod]
        public void Added_Posts_Show_Up()
        {
            ListPostsPage.GoTo(PostType.Posts);
            ListPostsPage.StoreCount();

            PostCreator.CreatePost();

            ListPostsPage.GoTo(PostType.Posts);
            Assert.AreEqual(ListPostsPage.PreviousPostCount + 1, ListPostsPage.CurrentPostCount, "Count of posts did not increase");

            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));

            ListPostsPage.TrashPost(PostCreator.PreviousTitle);
            Assert.AreEqual(ListPostsPage.PreviousPostCount, ListPostsPage.CurrentPostCount, "Couldn't trash post");
        }

        [TestMethod]
        public void Can_Search_Posts()
        {
            PostCreator.CreatePost();
            ListPostsPage.SearchForPost(PostCreator.PreviousTitle);
            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));
        }
    }
}
