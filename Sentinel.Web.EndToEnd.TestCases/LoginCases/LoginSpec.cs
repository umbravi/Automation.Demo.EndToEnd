using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sentinel.Web.EndToEnd.TestCases.LoginCases
{
    [TestClass]
    public class LoginSpec : BaseSpec
    {
        private void LoginAndValidateUser()
        {
            Test.Login.ValidateLoginPageDisplayed();
            Test.Login.EnterUsername();
            Test.Login.EnterPassword();
            Test.Login.ClickLoginButton();
            Test.Dashboard.ValidateLoggedInAsCurrentUser();
        }

        private void FailLoginAndValidateLoginPageDisplayed()
        {
            Test.Login.ValidateLoginPageDisplayed();
            Test.Login.EnterUsername();
            Test.Login.EnterPassword();
            Test.Login.ClickLoginButton();
            Test.Login.ValidateLoginPageDisplayed();
        }

        [TestMethod]
        public void Can_Login_As_LER()
        {
            Test.UserManagement.CreateBasicUser();
            LoginAndValidateUser();
        }

        [TestMethod]
        public void Can_Login_As_Admin()
        {
            Test.UserManagement.CreateAdminUser();
            LoginAndValidateUser();
        }

        [TestMethod]
        public void Cannot_Login_With_Invalid_UserName()
        {
            Test.UserManagement.CreateBasicUser();
            Test.UserManagement.UserData.Credential.Email = "NotAUserName@ThisNotEmail.com";
            FailLoginAndValidateLoginPageDisplayed();
        }

        [TestMethod]
        public void Cannot_Login_With_Invalid_Password()
        {
            Test.UserManagement.CreateBasicUser();
            Test.UserManagement.UserData.Credential.Password = "NotAPasswordNOTVALID01!";
            FailLoginAndValidateLoginPageDisplayed();
        }
    }
}
