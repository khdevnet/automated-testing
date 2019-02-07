using OpenQA.Selenium;
using Automation.Framework.Core.Selenium;

namespace Wordpress.Automation.Framework.Pages
{
    public class PageBase
    {
        protected static bool IsAtRightPage(string pageTitle)
        {
            var h1s = Driver.Instance.FindElements(By.TagName("h1"));
            if (h1s.Count > 0)
                return h1s[0].Text == pageTitle;
            return false;
        }
    }
}
