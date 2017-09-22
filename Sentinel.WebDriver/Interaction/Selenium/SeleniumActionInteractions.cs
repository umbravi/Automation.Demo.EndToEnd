using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Sentinel.WebDriver.Interaction.Selenium
{
    public class SeleniumActionInteractions
    {
        private readonly IWebDriver selenium;
        private readonly NgWebDriver protractor;

        public SeleniumActionInteractions(IWebDriver selenium, NgWebDriver protractor)
        {
            this.selenium = selenium;
            this.protractor = protractor;
        }

        public void NavigateToUrl(string url)
        {
            selenium.Navigate().GoToUrl(url);
        }

        public void ClickElement(By by)
        {
            var element = selenium.FindElement(@by);

            element.Click();
        }

        public void SendTextToElement(By by, string text)
        {
            var element = selenium.FindElement(@by);

            element.Clear();
            element.SendKeys(text);
        }

        public void SelectOptionByText(By by, string text)
        {
            var element = selenium.FindElement(@by);
            var selectElement = new SelectElement(element);

            selectElement.SelectByText(text);
        }
    }
}