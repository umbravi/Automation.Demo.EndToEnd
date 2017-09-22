using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Sentinel.WebDriver.Interaction.Selenium
{
    public class SeleniumGetInteractions
    {
        private readonly IWebDriver selenium;
        private readonly NgWebDriver protractor;

        public SeleniumGetInteractions(IWebDriver selenium, NgWebDriver protractor)
        {
            this.selenium = selenium;
            this.protractor = protractor;
        }

        public string GetElementTextBy(By by)
        {
            var element = selenium.FindElement(@by);
            var elementText = element.GetAttribute("text");

            return elementText;
        }

        public IList<string> GetOptionSelectedTextBy(By by)
        {
            var element = selenium.FindElement(@by);
            var selectElement = new SelectElement(element);

            return selectElement.Options.Where(o => o.Selected).Select(o => o.Text).ToList();
        }

        public IList<string> GetSelectOptionListTextBy(By by)
        {
            var element = selenium.FindElement(@by);
            var selectElement = new SelectElement(element);

            return selectElement.Options.Select(o => o.Text).ToList();
        }
    }
}