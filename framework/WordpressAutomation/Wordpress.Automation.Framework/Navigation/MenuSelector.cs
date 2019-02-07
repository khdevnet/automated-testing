using OpenQA.Selenium;
using Wordpress.Automation.Framework.Selenium;

namespace Wordpress.Automation.Framework.Navigation
{
    public class MenuSelector
    {
        public static void Select(string topLevelMenuId, string subMenuLinkText)
        {
            Driver.Instance.FindElement(By.Id(topLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(subMenuLinkText)).Click();
        }
    }
}