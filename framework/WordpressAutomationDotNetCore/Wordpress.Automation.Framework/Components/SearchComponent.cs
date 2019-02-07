using Automation.Framework.Core.Selenium;
using OpenQA.Selenium;

namespace Wordpress.Automation.Framework.Pages
{
    public class SearchComponent
    {
        public static void Search(string keywords)
        {
            var searchWrapper = Driver.Instance.FindElement(By.ClassName("search-box"));
            var searchBox = searchWrapper.FindElement(By.Id("post-search-input"));
            searchBox.SendKeys(keywords);

            var searchButton = searchWrapper.FindElement(By.Id("search-submit"));
            searchButton.Click();
        }
    }
}
