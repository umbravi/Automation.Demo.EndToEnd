using System;
using Sentinel.Test.EndToEnd.PageModel.DataModel.TestDataFactory;
using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.Test.EndToEnd.PageModel.Features;
using Sentinel.Test.EndToEnd.PageModel.Pages;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel
{
    public class TestData : IDisposable
    {
        public User CurrentUser;

        public LoginPage Login;
        public ForgotPasswordFeature ForgotPasswordFeature;

        private readonly BrowserDriver browserDriver;

        public TestData()
        {
            CurrentUser = DataGenerator.GenerateUser();

            browserDriver = new BrowserDriver(AppSettings.TargetBrowser);

            Login = new LoginPage(CurrentUser, browserDriver, AppSettings.UrlUnderTest);
            ForgotPasswordFeature = new ForgotPasswordFeature(CurrentUser, browserDriver);
        }

        public void Dispose()
        {
            browserDriver.KillDrivers();
        }
    }
}
