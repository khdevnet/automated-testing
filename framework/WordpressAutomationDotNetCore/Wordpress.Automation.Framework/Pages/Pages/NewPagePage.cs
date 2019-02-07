using System;
using OpenQA.Selenium;
using Wordpress.Automation.Framework.Navigation;
using Automation.Framework.Core.Selenium;

namespace Wordpress.Automation.Framework.Pages.Pages
{
    public class NewPagePage
    {
        public static void GoTo()
        {
            LeftNavigation.Pages.AddNew.Select();
        }

        public static CreatePageCommand CreatePage(string title)
        {
            return new CreatePageCommand(title);
        }

        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.XPath("//div[@class='components-panel__body post-publish-panel__postpublish-header is-opened']"));
            var newPostlink = message.FindElements(By.TagName("a"))[0];
            newPostlink.Click();
        }

        public static bool IsInEditMode()
        {
            return Driver.Instance.FindElement(By.XPath("//div[@class='edit-post-header__settings']//button[@aria-disabled='true']")) != null;
        }

        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("post-title-0"));
                if (title != null)
                    return title.Text;
                return string.Empty;
            }
        }
    }

    public class CreatePageCommand
    {
        private readonly string title;
        private string body;

        public CreatePageCommand(string title)
        {
            this.title = title;
        }

        public CreatePageCommand WithBody(string body)
        {
            this.body = body;
            return this;
        }

        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("post-title-0")).SendKeys(title);
            Driver.Instance.FindElement(By.ClassName("editor-block-list__layout")).Click();
            Driver.Instance.FindElement(By.Id("mce_0")).SendKeys(body);

            Driver.Wait(TimeSpan.FromSeconds(1));
            Driver.Instance.FindElement(By.XPath("//div[@class='edit-post-header__settings']/button[contains(text(),'Publish…')]")).Click();
            Driver.Instance.FindElement(By.XPath("//div[@class='editor-post-publish-panel__header-publish-button']//button[@type='button'][contains(text(),'Publish')]")).Click();
            Driver.Wait(TimeSpan.FromSeconds(2));

        }
    }
}
