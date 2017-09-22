using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.Registration
{
    public class SetPasswordPage
    {
        internal User User;

        private readonly BrowserDriver driver;
        private readonly RegistrationNavigation navigation;

        private const string PASSWORD_FIELD_ID = "Password";
        private const string CONFIRM_PASSWORD_FIELD_ID = "ConfirmPassword";
        private const string SHOW_PASSWORD_TEXT_CHECKBOX_ID = "ShowPlainText";

        public SetPasswordPage(User user, BrowserDriver driver)
        {
            navigation = new RegistrationNavigation(driver, "Next");
            User = user;
            this.driver = driver;
        }

        public void EnterPassword()
        {
            driver.Interactions.SendTextById(PASSWORD_FIELD_ID, User.Password);
        }

        public void EnterConfirmedPassword()
        {
            driver.Interactions.SendTextById(CONFIRM_PASSWORD_FIELD_ID, User.PasswordConfirm);
        }

        public void ShowPasswordText()
        {
            driver.Interactions.ClickById(SHOW_PASSWORD_TEXT_CHECKBOX_ID);
        }

        public void GoToPreviousPage()
        {
            navigation.GoToPreviousPage();
        }

        public void SubmitPasswordGoToNextPage()
        {
            navigation.GoToNextPage();
        }
    }
}
