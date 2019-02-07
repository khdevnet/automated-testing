﻿namespace Wordpress.Automation.Framework.Navigation
{
    public class LeftNavigation
    {
        public class Dashboard
        {
            public static void Select()
            {
                MenuSelector.Select("menu-dashboard", "Home");
            }
        }

        public class Posts
        {
            public class AddNew
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "Add New");
                }
            }

            public class AllPosts
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "All Posts");
                }
            }
        }

        public class Pages
        {
            public class AddNew
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-pages", "Add New");
                }
            }

            public class AllPages
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-pages", "All Pages");
                }
            }
        }
    }
}