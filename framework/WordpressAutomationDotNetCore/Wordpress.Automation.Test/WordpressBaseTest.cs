using Automation.Framework.Core.NUnit;
using NUnit.Framework;
using Wordpress.Automation.Framework.Workflows;

namespace Wordpress.Tests
{
    public abstract class WordpressBaseTest : EndToEndBaseTest
    {
        [SetUp]
        public override void Init()
        {
            base.Init();

            AuthenticationFlow.LogIn();
        }
    }
}
