using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation.Demo.TestCases.ExampleLoginCases
{
    [TestClass]
    public class ExampleLoginSpec : BaseSpec
    {
        private void ExampleLoginAndValidateUser()
        {
            Test.Login.ValidateLoginPageDisplayed();
            Test.Login.EnterUsername();
            Test.Login.EnterPassword();
            Test.Login.ClickLoginButton();
            Test.Dashboard.ValidateLoggedInAsCurrentUser();
        }

        private void ExampleFailLoginAndValidateLoginPageDisplayed()
        {
            Test.Login.ValidateLoginPageDisplayed();
            Test.Login.EnterUsername();
            Test.Login.EnterPassword();
            Test.Login.ClickLoginButton();
            Test.Login.ValidateLoginPageDisplayed();
        }

        [TestMethod]
        public void Example_Can_Login_As_Non_Admin()
        {
            Test.UserManagement.CreateBasicUser();
            ExampleLoginAndValidateUser();
        }

        [TestMethod]
        public void Example_Can_Login_As_Admin()
        {
            Test.UserManagement.CreateAdminUser();
            ExampleLoginAndValidateUser();
        }

        [TestMethod]
        public void Example_Cannot_Login_With_Invalid_UserName()
        {
            Test.UserManagement.CreateBasicUser();
            Test.UserManagement.UserData.Credential.Email = "NotAUserName@ThisNotEmail.com";
            ExampleFailLoginAndValidateLoginPageDisplayed();
        }

        [TestMethod]
        public void Example_Cannot_Login_With_Invalid_Password()
        {
            Test.UserManagement.CreateBasicUser();
            Test.UserManagement.UserData.Credential.Password = "NotAPasswordNOTVALID01!";
            ExampleFailLoginAndValidateLoginPageDisplayed();
        }
    }
}
