using System;
using Wordpress.Automation.Framework.Pages.Pages;
using Wordpress.Automation.Framework.TestData;

namespace Wordpress.Automation.Framework.Workflows
{
    public class PageCreator
    {
        public static void CreatePage()
        {
            NewPagePage.GoTo();

            PreviousTitle = CreateTitle();
            PreviousBody = CreateBody();

            NewPagePage.CreatePage(PreviousTitle).WithBody(PreviousBody).Publish();
        }

        public static string PreviousBody { get; set; }

        public static string PreviousTitle { get; set; }

        private static string CreateBody()
        {
            return ArticleDataGenerator.CreateRandomString() + ", body";
        }

        private static string CreateTitle()
        {
            return ArticleDataGenerator.CreateRandomString() + ", title";
        }

        public static void Initialize()
        {
            PreviousTitle = null;
            PreviousBody = null;
        }

        public static void Cleanup()
        {
            if (CreatedAPage)
                TrashPage();
        }

        private static void TrashPage()
        {
            ListPagesPage.GoTo(PageType.Pages);
            ListPagesPage.TrashPost(PreviousTitle);
            Initialize();
        }

        protected static bool CreatedAPage
        {
            get { return !String.IsNullOrEmpty(PreviousTitle); }
        }
    }
}
