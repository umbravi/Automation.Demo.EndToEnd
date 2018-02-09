using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.ForgotPassword
{
    public class ResetPasswordPage
    {
        private readonly string userPassword;

        private readonly BrowserDriver driver;

        private const string NEW_PASSWORD_FIELD_ID = "newPassword";
        private const string NEW_PASSWORD_CONFIRMATION_FIELD_ID = "reenterNewPassword";
        private const string NEXT_BUTTON_TEXT = "Next";

        public ResetPasswordPage(UserData userData, BrowserDriver driver)
        {
            userPassword = userData.Credential.Password;
            this.driver = driver;
        }

        public void SendNewPassword()
        {
            driver.Interactions.SendTextById(NEW_PASSWORD_FIELD_ID, userPassword);
        }

        public void SendConfirmationPassword()
        {
            driver.Interactions.SendTextById(NEW_PASSWORD_CONFIRMATION_FIELD_ID, userPassword);
        }

        public void SubmitNewPassword()
        {
            driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT);
        }
    }
}
