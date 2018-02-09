using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.Web.EndToEnd.PageModel.Pages.PreRegistration;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Features
{
    public class PreRegistrationFeature
    {
        public ContactInformationPage ContactInformation;
        public ConfirmationPage Confirmation;

        public PreRegistrationFeature(BrowserDriver driver, UserData userData)
        {
            ContactInformation = new ContactInformationPage(driver, userData);
            Confirmation = new ConfirmationPage(driver);
        }
    }
}
