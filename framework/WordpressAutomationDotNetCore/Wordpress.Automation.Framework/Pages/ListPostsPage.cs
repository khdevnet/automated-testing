using System.Collections.ObjectModel;
using System.Linq;
using Automation.Framework.Core.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Wordpress.Automation.Framework.Navigation;
using Wordpress.Automation.Framework.Workflows;

namespace Wordpress.Automation.Framework.Pages
{
    public class ListPostsPage
    {
        public static int PreviousPostCount { get; private set; }

        public static int CurrentPostCount
        {
            get { return GetPostCount(); }
        }

        public static void GoTo(PostType postType)
        {
            if (!AuthenticationFlow.IsAuthenticated)
            {
                AuthenticationFlow.LogIn();
            }

            switch (postType)
            {
                case PostType.Page:
                    LeftNavigation.Pages.AllPages.Select();
                    break;

                case PostType.Posts:
                    LeftNavigation.Posts.AllPosts.Select();
                    break;

            }
        }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText(title));
            postLink.Click();
        }

        public static void StoreCount()
        {
            PreviousPostCount = GetPostCount();
        }

        private static int GetPostCount()
        {
            var countText = Driver.Instance.FindElement(By.ClassName("displaying-num")).Text;
            return int.Parse(countText.Split(' ')[0]);
        }

        public static bool DoesPostExistWithTitle(string title)
        {
            return Driver.Instance.FindElements(By.LinkText(title)).Any();
        }

        public static void TrashPost(string title)
        {
            var rows = Driver.Instance.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                ReadOnlyCollection<IWebElement> links = null;
                Driver.NoWait(() => links = row.FindElements(By.LinkText(title)));

                if (links.Count > 0)
                {
                    Actions action = new Actions(Driver.Instance);
                    action.MoveToElement(links[0]);
                    action.Perform();
                    row.FindElement(By.ClassName("submitdelete")).Click();
                    return;
                }
            }

        }

        public static void SearchForPost(string searchString)
        {
            if (!IsAt)
                GoTo(PostType.Posts);

            SearchComponent.Search(searchString);
        }

        protected static bool IsAt
        {
            get
            {
                // Refactor: Can we create a generalized IsAt for all pages?
                var h2s = Driver.Instance.FindElements(By.TagName("h1"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Posts";
                return false;
            }
        }
    }

    public enum PostType
    {
        Page,
        Posts
    }
}
