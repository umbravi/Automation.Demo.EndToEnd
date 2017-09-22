using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.ForgotPassword
{
    public class ForgotPasswordPage
    {
        internal User User;

        private readonly BrowserDriver driver;

        private const string MY_URI = "Account/ForgotPassword";
        private const string USERAME_FIELD_ID = "Username";
        private const string NEXT_BUTTON_TEXT = "Next";

        public ForgotPasswordPage(User user, BrowserDriver driver)
        {
            User = user;
            this.driver = driver;
        }

        public void SendUsername()
        {
            driver.Interactions.SendTextById(USERAME_FIELD_ID, User.Username);
        }

        public void ClickNextButton()
        {
            driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT);
        }
    }
}
