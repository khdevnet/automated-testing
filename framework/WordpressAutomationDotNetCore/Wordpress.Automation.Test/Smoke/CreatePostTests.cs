using NUnit.Allure.Core;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Workflows;

namespace Wordpress.Tests.Smoke
{
    [TestFixture]
    [AllureNUnit]
    public class CreatePostTests : WordpressBaseTest
    {
        [Test]
        public void Can_Create_A_Basic_Post()
        {
            PostCreator.CreatePost();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, PostCreator.PreviousTitle, "Title did not match new post.");
            AuthenticationFlow.LogIn();

            PostCreator.Cleanup();
        }

    }
}
