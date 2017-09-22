using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages
{
    public class LoginPage
    {
        internal User User;

        private readonly BrowserDriver driver;

        private const string USER_NAME_FIELD_ID = "Username";
        private const string PASSWORD_FIELD_ID = "Password";
        private const string LOGIN_BUTTON_TEXT = "Login";
        private const string REGISTER_LINK_TEXT = "Register for Sentinel";
        private const string FORGOT_LINK_TEXT = "Forgot?";
        private const string TERMS_OF_USE_LINK_TEXT = "Terms of Use";
        private const string MY_URI = "Account/Login";
        private readonly string urlUnderTest;

        public LoginPage(User user, BrowserDriver driver, string urlUnderTest)
        {
            User = user;
            this.driver = driver;
            this.urlUnderTest = urlUnderTest;
        }

        public void NavigateToMe()
        {
            driver.Interactions.NavigateToUrl(urlUnderTest);
        }

        public void EnterUsername()
        {
            driver.Interactions.SendTextById(USER_NAME_FIELD_ID, User.Username);
        }

        public void EnterPassword()
        {
            driver.Interactions.SendTextById(PASSWORD_FIELD_ID, User.Password);
        }

        internal void ClickLoginButton()
        {
            driver.Interactions.ClickButtonByText(LOGIN_BUTTON_TEXT);
        }

        internal void OpenForgotPasswordPage()
        {
            driver.Interactions.ClickLinkByText(FORGOT_LINK_TEXT);
        }

        internal void OpenTermsOfUsePage()
        {
            driver.Interactions.ClickLinkByText(TERMS_OF_USE_LINK_TEXT);
        }

        internal void OpenRegistrationPage()
        {
            driver.Interactions.ClickLinkByText(REGISTER_LINK_TEXT);
        }

        internal void ValidateOnTheCorrectPage()
        {
            driver.Interactions.ValidateUri(MY_URI);
        }
    }
}
