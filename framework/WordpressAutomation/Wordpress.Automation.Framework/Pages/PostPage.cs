﻿using System;
using OpenQA.Selenium;
using Wordpress.Automation.Framework.Selenium;

namespace Wordpress.Automation.Framework.Pages
{
    public class PostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.ClassName("entry-title"));
                if (title != null)
                    return title.Text;
                return String.Empty;
            }
        }
    }
}
