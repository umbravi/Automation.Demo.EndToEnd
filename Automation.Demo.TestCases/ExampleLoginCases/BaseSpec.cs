using Automation.Demo.PageModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation.Demo.TestCases.ExampleLoginCases
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
