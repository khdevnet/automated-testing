namespace Wordpress.Automation.Framework.Pages
{
    public class DashboardPage : PageBase
    {
        public static bool IsAt => IsAtRightPage("Dashboard");
    }
}
