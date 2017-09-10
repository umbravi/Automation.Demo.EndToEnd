using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Libraries.WebDriver
{
    internal class WebDriverPrimitiveMethods
    {
        private IWebDriver _selenium;
        private NgWebDriver _protractor;

        public WebDriverPrimitiveMethods(IWebDriver selenium, NgWebDriver protractor)
        {
            _selenium = selenium;
            _protractor = protractor;
        }

        internal void NavigateToUrl(string url)
        {
            _selenium.Navigate().GoToUrl(url);
        }

        internal void ClickElement(By by)
        {
            var element = _selenium.FindElement(by);

            element.Click();
        }

        internal void SendTextToElement(By by, string text)
        {
            var element = _selenium.FindElement(by);

            element.Clear();
            element.SendKeys(text);
        }

        internal void SelectOptionByText(By by, string text)
        {
            var element = _selenium.FindElement(by);
            var selectElement = new SelectElement(element);

            selectElement.SelectByText(text);
        }

        internal void ValidateElementHasText(By by, string text)
        {
            var element = _selenium.FindElement(by);

            var actualText = element.GetAttribute("text");
            if (text != actualText)
                throw new Exception($"Expected text not found: Expected - \"{text}\"  was \"{actualText}\"");
        }

        internal void ValidateOptionSelectedByText(By by, string text)
        {
            var element = _selenium.FindElement(by);
            var selectElement = new SelectElement(element);

            var actualOptionText = selectElement.SelectedOption.GetAttribute("text");
            if (text != actualOptionText)
                throw new Exception($"Expected option not selected: Expected - \"{text}\"  was \"{actualOptionText}\"");
        }

        internal void ValidateUrlContainsUri(string uri)
        {
            var url = _selenium.Url;

            if (!url.Contains(uri))
                throw new Exception($"Expected uri not present: Expected - \"{uri}\" was \"{url}\"");
        }
    }
}
