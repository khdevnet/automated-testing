using NUnit.Framework;
using Wordpress.Automation.Framework.Workflows;
using Wordpress.Tests;

namespace Wordpress.Automation.Test.Posts
{
    public abstract class PostBaseTest : WordpressBaseTest
    {
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
