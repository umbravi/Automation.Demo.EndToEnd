using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sentinel.Test.EndToEnd.PageModel;

namespace Sentinel.Test.EndToEnd.TestCases
{
    [TestClass]
    public class LoginSpec
    {
        [TestInitialize]
        public void SetUp()
        { }

        [TestCleanup]
        public void TearDown()
        { }

        [TestMethod]
        public void Login()
        {
            using (var test = new TestData())
            {
                test.Login.NavigateToMe();
                test.Login.EnterUsername();
                test.Login.EnterPassword();
                test.Login.ClickLoginButton();
            }
        }
    }
}
