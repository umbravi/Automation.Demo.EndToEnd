using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.Web.EndToEnd.PageModel.Pages.Registration;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Features
{
    public class RegistrationFeature
    {
        public AcceptTermsOfUsePage AcceptTermsOfUse;
        public AcceptUserAgreementPage AcceptUserAgreement;
        public EnterMyProfilePage MyProfile;

        public RegistrationFeature(BrowserDriver driver, UserData userData)
        {
            AcceptTermsOfUse = new AcceptTermsOfUsePage(driver);
            AcceptUserAgreement = new AcceptUserAgreementPage(driver);
            MyProfile = new EnterMyProfilePage(driver, userData);
        }
    }
}
