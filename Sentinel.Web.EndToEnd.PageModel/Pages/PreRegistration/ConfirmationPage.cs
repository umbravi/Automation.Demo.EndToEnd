using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.PreRegistration
{
    public class ConfirmationPage
    {
        private readonly BrowserDriver driver;

        private const string BACK_TO_LOGIN_BUTTON_TEXT = "Back to login";
        private const string CLOSE_WINDOW_BUTTON_TEXT = "Close window";
        private const string CONFIRMATION_PAGE_DISPLAY_VALIDATION_TEXT = "The Sentinel registration form was successfully submitted";

        public ConfirmationPage(BrowserDriver driver)
        {
            this.driver = driver;
        }

        public void ValidateIAmDisplayed() { driver.Interactions.ValidateTextIsDisplayed(CONFIRMATION_PAGE_DISPLAY_VALIDATION_TEXT);  }
        public void ClickBackToLoginButton() { driver.Interactions.ClickButtonByText(BACK_TO_LOGIN_BUTTON_TEXT); }
        public void ClickCloseWindowButton() { driver.Interactions.ClickButtonByText(CLOSE_WINDOW_BUTTON_TEXT); }
    }
}
