using NUnit.Allure.Attributes;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Workflows;
using Wordpress.Tests;

namespace Wordpress.Automation.Test.Posts
{
    [TestFixture]
    [AllureFeature(Features.WordpressPosts)]
    public class PostsTests : WordpressBaseTest
    {
        [Test]
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

        [Test]
        public void Can_Search_Posts()
        {
            PostCreator.CreatePost();
            ListPostsPage.SearchForPost(PostCreator.PreviousTitle);
            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));
        }

        [SetUp]
        public override void Init()
        {
            base.Init();
            PostCreator.Initialize();

        }

        [TearDown]
        public override void Cleanup()
        {
            PostCreator.Cleanup();
            base.Cleanup();
        }
    }
}
