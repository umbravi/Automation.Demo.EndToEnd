using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Sentinel.WebDriver.Interaction.Selenium
{
    public class SeleniumValidationInteractions
    {
        private readonly IWebDriver selenium;
        private readonly NgWebDriver protractor;

        public SeleniumValidationInteractions(IWebDriver selenium, NgWebDriver protractor)
        {
            this.selenium = selenium;
            this.protractor = protractor;
        }

        public void ValidateElementHasText(By by, string text)
        {
            var element = selenium.FindElement(@by);

            var actualText = element.GetAttribute("text");
            if (text != actualText)
                throw new Exception($"Expected text not found: Expected - \"{text}\" was \"{actualText}\"");
        }

        public void ValidateOptionSelectedByText(By by, string text)
        {
            var element = selenium.FindElement(@by);
            var selectElement = new SelectElement(element);

            var actualOptionText = selectElement.SelectedOption.GetAttribute("text");
            if (text != actualOptionText)
                throw new Exception($"Expected option not selected: Expected - \"{text}\" was \"{actualOptionText}\"");
        }

        public void ValidateUrlContainsUri(string uri)
        {
            var url = selenium.Url;

            if (!url.Contains(uri))
                throw new Exception($"Expected uri not present: Expected - \"{uri}\" was \"{url}\"");
        }
    }
}