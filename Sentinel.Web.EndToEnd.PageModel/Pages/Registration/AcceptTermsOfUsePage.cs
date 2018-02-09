using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.Registration
{
    public class AcceptTermsOfUsePage
    {

        private readonly BrowserDriver driver;
        private const string ACCEPT_TERMS_CHECKBOX_ID = "check_agreement";
        private const string CONTINUE_BUTTON_TEXT = "Continue";

        public AcceptTermsOfUsePage(BrowserDriver driver)
        {
            this.driver = driver;
        }

        public void AcceptTermsOfUse()
        {
            driver.Interactions.ClickById(ACCEPT_TERMS_CHECKBOX_ID);
        }

        public void ClickNext()
        {
            driver.Interactions.ClickById(CONTINUE_BUTTON_TEXT);
        }
    }
}
