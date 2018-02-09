using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.ForgotPassword
{
    public class ForgotPasswordPage
    {
        private readonly string userEmail;

        private readonly BrowserDriver driver;
        
        private const string USERAME_FIELD_ID = "Username";
        private const string NEXT_BUTTON_TEXT = "Next";

        public ForgotPasswordPage(UserData userData, BrowserDriver driver)
        {
            userEmail = userData.Credential.Email;
            this.driver = driver;
        }

        public void SendUserEmail()
        {
            driver.Interactions.SendTextById(USERAME_FIELD_ID, userEmail);
        }

        public void ClickNextButton()
        {
            driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT);
        }
    }
}