using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.PreRegistration
{
    public class ContactInformationPage
    {
        private UserData user;

        private readonly BrowserDriver driver;

        private const string FORM_ERRORS_MODAL_XPATH = "";
        private const string FIRST_NAME_FIELD_ID = "";
        private const string USER_LAST_NAME_FIELD_ID = "";
        private const string PROFESSIONAL_EMAIL_FIELD_ID = "";
        private const string MOBILE_PHONE_FIELD_ID = "";
        private const string ORGANIZATION_GOVERNMENT_RADIAL_BUTTON_TEXT = "";
        private const string ORGANIZATION_GOVERNMENT_JURISDICTION_DROPDOWN_ID = "";
        private const string ORGANIZATION_GOVERNMENT_FEDERAL_CABINET_DROPDOWN_ID = "";
        private const string ORGANIZATION_GOVERNMENT_AGENCY_DROPDOWN_ID = "";
        private const string ORGANIZATION_NON_GOVERNMENT_RADIAL_BUTTON_TEXT = "";
        private const string ORGANIZATION_NON_GOVERNMENT_INDUSTRY_DROPDOWN_ID = "";
        private const string ORGANIZATION_NON_GOVERNMENT_COMPANY_DROPDOWN_ID = "";
        private const string ADMIN_CHECKBOX_ID = "";
        private const string REGISTER_BUTTON_TEXT = "Register";
        private const string BACK_TO_LOGIN_BUTTON_TEXT = "Back to login";

        public ContactInformationPage(BrowserDriver driver, UserData user)
        {
            this.driver = driver;
            this.user = user;
        }

        public void GetFormErrorText() { driver.Interactions.GetElementTextByXpath(FORM_ERRORS_MODAL_XPATH); }
        public void EnterFirstName() { driver.Interactions.SendTextById(FIRST_NAME_FIELD_ID, user.AgentProfile.FirstName); }
        public void EnterLastName() { driver.Interactions.SendTextById(USER_LAST_NAME_FIELD_ID, user.AgentProfile.LastName); }
        public void EnterEmail() { driver.Interactions.SendTextById(PROFESSIONAL_EMAIL_FIELD_ID, user.AgentProfile.Email); }
        public void EnterMobilePhone() { driver.Interactions.SendTextById(MOBILE_PHONE_FIELD_ID, user.AgentProfile.PhoneNumber); }
        public void SelectGovernmentRadialButton() { driver.Interactions.ClickButtonByText(ORGANIZATION_GOVERNMENT_RADIAL_BUTTON_TEXT); }
        public void SelectGovernmentJurisdiction() { driver.Interactions.SelectOptionTextById(ORGANIZATION_GOVERNMENT_JURISDICTION_DROPDOWN_ID, ""); }
        public void SelectGovernmentCabinet() { driver.Interactions.SelectOptionTextById(ORGANIZATION_GOVERNMENT_FEDERAL_CABINET_DROPDOWN_ID, ""); }
        public void SelectGovernmentAgency() { driver.Interactions.SelectOptionTextById(ORGANIZATION_GOVERNMENT_AGENCY_DROPDOWN_ID, user.AgentProfile.Agency); }
        public void SelectNonGovernmentRadialButton() { driver.Interactions.ClickButtonByText(ORGANIZATION_NON_GOVERNMENT_RADIAL_BUTTON_TEXT); }
        public void SelectNonGovernmentIndustry() { driver.Interactions.SelectOptionTextById(ORGANIZATION_NON_GOVERNMENT_INDUSTRY_DROPDOWN_ID, ""); }
        public void SelectNonGovernmentCompany() { driver.Interactions.SelectOptionTextById(ORGANIZATION_NON_GOVERNMENT_COMPANY_DROPDOWN_ID, ""); }
        public void ClickAdminCheckBox() { driver.Interactions.ClickById(ADMIN_CHECKBOX_ID); }
        public void ClickRegisterButton() { driver.Interactions.ClickButtonByText(REGISTER_BUTTON_TEXT); }
        public void ClickBackToLoginButton() { driver.Interactions.ClickButtonByText(BACK_TO_LOGIN_BUTTON_TEXT); }
    }
}
