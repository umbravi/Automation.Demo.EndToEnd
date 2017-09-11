using System;
using Sentinel.Test.EndToEnd.PageModel.DataModel;
using Sentinel.Test.EndToEnd.PageModel.Pages;
using Sentinel.Test.EndToEnd.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel
{
    public class TestData : IDisposable
    {
        public User CurrentUser;

        public LoginPage Login;

        private WebDrivers _webDrivers;

        public TestData()
        {
            this.CurrentUser = DataGenerator.GenerateUser();

            this._webDrivers = new WebDrivers(AppSettings.TargetBrowser);

            Login = new LoginPage(CurrentUser, _webDrivers.Interactions, AppSettings.UrlUnderTest);
        }

        public void Dispose()
        {
            this._webDrivers.KillDrivers();
        }
    }
}
