using System;
using System.Collections.Generic;
using System.Text;
using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.WebDriver;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.Registration
{
    public class EnterMyProfilePage
    {
        private UserData user;

        private BrowserDriver driver;

        private const string JOB_TITLE_FIELD_ID = "JobTitle";
        private const string FIRST_NAME_FIELD_ID = "FirstName";
        private const string MIDDLE_INITIAL_FIELD_ID = "MiddleInitial";
        private const string LAST_NAME_FIELD_ID = "LastName";
        private const string LOCATION_DROPDOWN_ID = "Location";
        private const string DEPARTMENT_DROPDOWN_ID = "Department";
        private const string BADGE_NUMBER_FIELD_ID = "BadgeNumber";
        private const string FAX_NUMBER_FIELD_ID = "FaxNumber";
        private const string PRIMARY_ADDRESS_STREET1_FIELD_ID = "PrimaryAddress1";
        private const string PRIMARY_ADDRESS_STREET2_FIELD_ID = "PrimaryAddress2";
        private const string PRIMARY_ADDRESS_CITY_FIELD_ID = "PrimaryAddressCity";
        private const string PRIMARY_ADDRESS_STATE_CODE_FIELD_ID = "PrimaryAddressState";
        private const string PRIMARY_ADDRESS_ZIP_FIELD_ID = "PrimaryAddressZip";
        private const string EMAIL_DISPLAY_ID = "Email";
        private const string AGENCY_DISPLAY_ID = "Agency";
        private const string MOBILE_PHONE_DISPLAY_ID = "MobilePhone";
        private const string NEXT_BUTTON_TEXT = "Next";

        public EnterMyProfilePage(BrowserDriver driver, UserData user)
        {
            this.user = user;
            this.driver = driver;
        }

        public void EnterJobTitleField() { driver.Interactions.SendTextById(JOB_TITLE_FIELD_ID, user.AgentProfile.JobTitle); }
        public void EnterFirstNameField() { driver.Interactions.SendTextById(FIRST_NAME_FIELD_ID, user.AgentProfile.FirstName); }
        public void EnterMiddleInitialField() { driver.Interactions.SendTextById(MIDDLE_INITIAL_FIELD_ID, user.AgentProfile.MiddleInital); }
        public void EnterLastNameField() { driver.Interactions.SendTextById(LAST_NAME_FIELD_ID, user.AgentProfile.LastName); }
        public void EnterBadgeNumberField() { driver.Interactions.SendTextById(BADGE_NUMBER_FIELD_ID, user.AgentProfile.BadgeNumber); }
        public void EnterFaxNumberField() { driver.Interactions.SendTextById(FAX_NUMBER_FIELD_ID, user.AgentProfile.FaxNumber); }
        public void EnterPrimaryAddress_Street1Field() { driver.Interactions.SendTextById(PRIMARY_ADDRESS_STREET1_FIELD_ID, user.AgentProfile.Street1); }
        public void EnterPrimaryAddress_Street2Field() { driver.Interactions.SendTextById(PRIMARY_ADDRESS_STREET2_FIELD_ID, user.AgentProfile.Street2); }
        public void EnterPrimaryAddress_CityField() { driver.Interactions.SendTextById(PRIMARY_ADDRESS_CITY_FIELD_ID, user.AgentProfile.City); }
        public void EnterPrimaryAddress_StateCodeField() { driver.Interactions.SendTextById(PRIMARY_ADDRESS_STATE_CODE_FIELD_ID, user.AgentProfile.State); }
        public void EnterPrimaryAddress_ZipField() { driver.Interactions.SendTextById(PRIMARY_ADDRESS_ZIP_FIELD_ID, user.AgentProfile.ZipCode); }
        public void SelectLocationInDropdown() { driver.Interactions.SelectOptionTextById(LOCATION_DROPDOWN_ID, user.AgentProfile.Location); }
        public void SelectDepartmentInDropdown() { driver.Interactions.SelectOptionTextById(DEPARTMENT_DROPDOWN_ID, user.AgentProfile.Department); }
        public void VerifyAgentEmailDisplayed() { driver.Interactions.ValidateTextIsDisplayed(user.AgentProfile.Email); }
        public void VerifyAgentPhoneNumberDisplayed() { driver.Interactions.ValidateTextIsDisplayed(user.AgentProfile.PhoneNumber); }
        public void ClickNextButton() { driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT); }
    }
}
