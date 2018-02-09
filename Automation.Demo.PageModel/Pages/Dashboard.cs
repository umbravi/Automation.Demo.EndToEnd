using Automation.Demo.DataModel;
using Automation.Demo.WebDriver;

namespace Automation.Demo.PageModel.Pages
{
    public class DashboardPage
    {
        private UserData user;

        private readonly BrowserDriver driver;

        private const string DASHBOARD_HEADER_NAME = "Dashboard";

        public DashboardPage(BrowserDriver driver, UserData userData)
        {
            user = userData;
            this.driver = driver;
        }

        public void ValidateDashboardDisplayed()
        {
            driver.Interactions.ValidateTextIsDisplayed("Dashboard");
        }

        public void ValidateLoggedInAsCurrentUser()
        {
            driver.Interactions.ValidateTextIsDisplayed(user.Credential.Email);
        }
    }
}
