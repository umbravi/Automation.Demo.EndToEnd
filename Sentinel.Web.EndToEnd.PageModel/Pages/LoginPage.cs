using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages
{
    public class LoginPage
    {
        private UserData user;

        private readonly BrowserDriver driver;

        private const string USER_NAME_FIELD_ID = "Email";
        private const string PASSWORD_FIELD_ID = "Password";
        private const string LOGIN_BUTTON_TEXT = "Login";
        private const string REGISTER_LINK_TEXT = "Register for Sentinel";
        private const string FORGOT_LINK_TEXT = "Forgot?";
        private const string TERMS_OF_USE_LINK_TEXT = "Terms of Use";
        private const string MY_URI = "Account/Login";
        private readonly string urlUnderTest;

        public LoginPage(BrowserDriver driver, UserData userData, string urlUnderTest)
        {
            user = userData;
            this.driver = driver;
            this.urlUnderTest = urlUnderTest;
            NavigateToMe();
        }

        public void LoginWorkflow()
        {
            NavigateToMe();
            EnterUsername();
            EnterPassword();
            ClickLoginButton();
        }

        public void NavigateToMe()
        {
            driver.Interactions.NavigateToUrl(urlUnderTest);
        }

        public void EnterUsername()
        {
            driver.Interactions.SendTextById(USER_NAME_FIELD_ID, user.Credential.Email);
        }

        public void EnterPassword()
        {
            driver.Interactions.SendTextById(PASSWORD_FIELD_ID, user.Credential.Password);
        }

        public void ClickLoginButton()
        {
            driver.Interactions.ClickButtonByText(LOGIN_BUTTON_TEXT);
        }

        public void OpenForgotPasswordPage()
        {
            driver.Interactions.ClickLinkByText(FORGOT_LINK_TEXT);
        }

        public void OpenTermsOfUsePage()
        {
            driver.Interactions.ClickLinkByText(TERMS_OF_USE_LINK_TEXT);
        }

        public void OpenRegistrationPage()
        {
            driver.Interactions.ClickLinkByText(REGISTER_LINK_TEXT);
        }

        public void ValidateLoginPageDisplayed()
        {
            driver.Interactions.ValidateUri(MY_URI);
            driver.Interactions.ValidateElementExistsById(USER_NAME_FIELD_ID);
        }
    }
}
