using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages
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
