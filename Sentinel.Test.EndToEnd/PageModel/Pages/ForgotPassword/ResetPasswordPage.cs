using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.ForgotPassword
{
    public class ResetPasswordPage
    {
        internal User User;

        private readonly BrowserDriver driver;

        private const string NEW_PASSWORD_FIELD_ID = "newPassword";
        private const string NEW_PASSWORD_CONFIRMATION_FIELD_ID = "reenterNewPassword";
        private const string NEXT_BUTTON_TEXT = "Next";

        public ResetPasswordPage(User user, BrowserDriver driver)
        {
            User = user;
            this.driver = driver;
        }

        public void SendNewPassword()
        {
            driver.Interactions.SendTextById(NEW_PASSWORD_FIELD_ID, User.Password);
        }

        public void SendConfirmationPassword()
        {
            driver.Interactions.SendTextById(NEW_PASSWORD_CONFIRMATION_FIELD_ID, User.PasswordConfirm);
        }

        public void SubmitNewPassword()
        {
            driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT);
        }
    }
}
