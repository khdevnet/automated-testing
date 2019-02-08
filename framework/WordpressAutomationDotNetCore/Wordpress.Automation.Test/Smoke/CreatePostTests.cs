using NUnit.Allure.Attributes;
using NUnit.Framework;
using Wordpress.Automation.Framework.Pages;
using Wordpress.Automation.Framework.Workflows;
using Wordpress.Automation.Test;

namespace Wordpress.Tests.Smoke
{
    [TestFixture]
    [AllureFeature(Features.WordpressSmokeTests)]
    public class CreatePostTests : WordpressBaseTest
    {
        [Test]
        public void Can_Create_A_Basic_Post()
        {
            throw new System.Exception();
            PostCreator.CreatePost();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, PostCreator.PreviousTitle, "Title did not match new post.");
            AuthenticationFlow.LogIn();

            PostCreator.Cleanup();
        }

    }
}
