using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sentinel.Web.EndToEnd.PageModel;

namespace Sentinel.Web.EndToEnd.TestCases
{
    public abstract class BaseSpec
    {
        protected TestData Test;

        [TestInitialize]
        public void SetUp()
        {
            // Initalizes test data objects and webdriver
            Test = new TestData(AppSettings.TargetBrowser, AppSettings.ApplicationUnderTestUrl);
        }

        [TestCleanup]
        public void TearDown()
        {
            Test.Dispose();
        }
    }
}
