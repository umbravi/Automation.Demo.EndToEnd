using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.Registration
{
    public class ConfirmationCode
    {
        internal User User;

        private readonly BrowserDriver driver;
        private readonly RegistrationNavigation navigation;

        private const string EMAIL_RADIAL_BUTTON_ID = "";
        private const string EMAIL_TEXT_BOX_ID = "";
        private const string TEXT_MESSAGE_RADIAL_BUTTON_ID = "";
        private const string TEXT_MESSAGE_TEXT_BOX_ID = "";
        private const string CALL_ME_NOW_RADIAL_BUTTON_ID = "";
        private const string CALL_ME_NOW_TEXT_BOX_ID = "";
        private const string SEND_CODE_NOW_BUTTON_ID = "";
        private const string CONFIRMATION_CODE_TEXT_BOX_ID = "";

        public ConfirmationCode(User user, BrowserDriver driver)
        {
            navigation = new RegistrationNavigation(driver, "Next");
            User = user;
            this.driver = driver;
        }

        public void SelectEmailAsMethod()
        {
            driver.Interactions.ClickById(EMAIL_RADIAL_BUTTON_ID);
        }

        public void EnterEmailAddressIntoEmailField()
        {
            driver.Interactions.SendTextById(EMAIL_TEXT_BOX_ID, User.Email);
        }

        public void SelectTextMessageAsMethod()
        {
            driver.Interactions.ClickById(TEXT_MESSAGE_RADIAL_BUTTON_ID);
        }

        public void EnterPhoneNumberIntoTextMessageField()
        {
            driver.Interactions.SendTextById(TEXT_MESSAGE_TEXT_BOX_ID, User.CellPhoneNumber);
        }

        public void SelectCallMeNowAsMethod()
        {
            driver.Interactions.ClickById(CALL_ME_NOW_RADIAL_BUTTON_ID);
        }

        public void EnterPhoneNumberIntoCallMeNowTextField()
        {
            driver.Interactions.SendTextById(CALL_ME_NOW_TEXT_BOX_ID, User.CellPhoneNumber);
        }

        public void SendCodeNow()
        {
            driver.Interactions.ClickById(SEND_CODE_NOW_BUTTON_ID);
        }

        public void EnterConfirmationCode()
        {
            driver.Interactions.SendTextById(CONFIRMATION_CODE_TEXT_BOX_ID, "235168");
        }

        public void GoToPreviousPage()
        {
            navigation.GoToPreviousPage();
        }

        public void SubmitCodeAndGoToNextPage()
        {
            navigation.GoToNextPage();
        }
    }
}
