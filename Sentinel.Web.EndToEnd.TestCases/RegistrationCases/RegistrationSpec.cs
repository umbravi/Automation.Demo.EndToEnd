using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sentinel.Web.EndToEnd.TestCases.RegistrationCases
{
    [TestClass]
    public class RegistrationSpec : BaseSpec
    {
        [TestInitialize]
        public void Login()
        {
            Test.UserManagement.CreateBasicUser();
            Test.Login.LoginWorkflow();
        }

        [TestMethod]
        public void Can_Register_New_Agent()
        {

        }
    }
}
