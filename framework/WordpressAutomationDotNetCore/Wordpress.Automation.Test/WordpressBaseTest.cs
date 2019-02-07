using Automation.Framework.Core.Selenium;
using Wordpress.Automation.Framework.Workflows;
using NUnit.Framework;
using System;
using System.IO;

namespace Wordpress.Tests
{
    public abstract class WordpressBaseTest
    {
        [SetUp]
        public virtual void Init()
        {
            Driver.Initialize();

            AuthenticationFlow.LogIn();
        }

        [TearDown]
        public virtual void Cleanup()
        {
            Driver.Close();
        }
    }
}
