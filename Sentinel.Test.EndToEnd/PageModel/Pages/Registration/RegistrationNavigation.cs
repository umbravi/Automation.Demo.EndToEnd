using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.Registration
{
    public class RegistrationNavigation
    {
        private readonly BrowserDriver driver;

        private const string PREVIOUS_BUTTON_TEXT = "Previous";
        private readonly string nextButtonText;

        internal RegistrationNavigation(BrowserDriver driver, string nextPageButtonText)
        {
            this.driver = driver;
            nextButtonText = nextPageButtonText;
        }

        public void GoToPreviousPage()
        {
            driver.Interactions.ClickButtonByText(PREVIOUS_BUTTON_TEXT);
        }

        public void GoToNextPage()
        {
            driver.Interactions.ClickButtonByText(nextButtonText);
        }
    }
}
