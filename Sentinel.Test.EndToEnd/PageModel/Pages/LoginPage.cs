using Sentinel.Test.EndToEnd.PageModel.DataModel;
using Sentinel.Test.EndToEnd.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages
{
    public class LoginPage
    {
        internal User User;

        private Interactions _interactions;

        private string UserNameFieldId = "Email";
        private string PasswordFieldId = "Password";
        private string LoginButtonText = "Login";
        private string RegisterLinkText = "Register for Sentinel";
        private string ForgotLinkText = "Forgot?";
        private string TermsOfUseLinkText = "Terms of Use";
        private string MyUri = "Account/Login";
        private string UrlUnderTest;

        public LoginPage(User user, Interactions interactions, string urlUnderTest)
        {
            this.User = user;
            this._interactions = interactions;
            this.UrlUnderTest = urlUnderTest;
        }

        public void NavigateToMe()
        {
            _interactions.NavigateToUrl(UrlUnderTest);
        }

        public void EnterUsername()
        {
            _interactions.SendTextById(UserNameFieldId, User.Email);
        }

        public void EnterPassword()
        {
            _interactions.SendTextById(PasswordFieldId, User.Password);
        }

        internal void ClickLoginButton()
        {
            _interactions.ClickButtonByText(LoginButtonText);
        }

        internal void OpenForgotPasswordPage()
        {
            _interactions.ClickLinkByText(ForgotLinkText);
        }

        internal void OpenTermsOfUsePage()
        {
            _interactions.ClickLinkByText(TermsOfUseLinkText);
        }

        internal void ValidateOnTheCorrectPage()
        {
            _interactions.ValidateUri(MyUri);
        }
    }
}
