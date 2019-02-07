﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.Automation.Framework.Pages;

namespace Wordpress.Tests.Smoke
{
    [TestClass]
    public class CreatePostTests : WordpressBaseTest
    {
        [TestMethod]
        public void Can_Create_A_Basic_Post()
        {
            NewPostPage.GoTo();
            NewPostPage.CreatePost("This is the test post title")
                .WithBody("Hi, this is the body.")
                .Publish();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "This is the test post title", "Title did not match new post.");
        }

    }
}
