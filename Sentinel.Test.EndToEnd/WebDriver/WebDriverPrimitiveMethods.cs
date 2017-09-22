using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Sentinel.Test.EndToEnd.WebDriver
{
    internal class WebDriverPrimitiveMethods
    {
        private readonly IWebDriver selenium;
        private NgWebDriver protractor;


        internal WebDriverPrimitiveMethods(IWebDriver selenium, NgWebDriver protractor)
        {
            this.selenium = selenium;
            this.protractor = protractor;
        }

        #region Actions

        internal void NavigateToUrl(string url)
        {
            selenium.Navigate().GoToUrl(url);
        }

        internal void ClickElement(By by)
        {
            var element = selenium.FindElement(by);

            element.Click();
        }

        internal void SendTextToElement(By by, string text)
        {
            var element = selenium.FindElement(by);

            element.Clear();
            element.SendKeys(text);
        }

        internal void SelectOptionByText(By by, string text)
        {
            var element = selenium.FindElement(by);
            var selectElement = new SelectElement(element);

            selectElement.SelectByText(text);
        }

        #endregion

        #region Gets

        internal string GetElementTextBy(By by)
        {
            var element = selenium.FindElement(by);
            var elementText = element.GetAttribute("text");

            return elementText;
        }

        internal IList<string> GetOptionSelectedTextBy(By by)
        {
            var element = selenium.FindElement(by);
            var selectElement = new SelectElement(element);

            return selectElement.Options.Where(o => o.Selected).Select(o => o.Text).ToList();
        }

        internal IList<string> GetSelectOptionListTextBy(By by)
        {
            var element = selenium.FindElement(by);
            var selectElement = new SelectElement(element);

            return selectElement.Options.Select(o => o.Text).ToList();
        }

        #endregion

        #region Validation

        internal void ValidateElementHasText(By by, string text)
        {
            var element = selenium.FindElement(by);

            var actualText = element.GetAttribute("text");
            if (text != actualText)
                throw new Exception($"Expected text not found: Expected - \"{text}\" was \"{actualText}\"");
        }

        internal void ValidateOptionSelectedByText(By by, string text)
        {
            var element = selenium.FindElement(by);
            var selectElement = new SelectElement(element);

            var actualOptionText = selectElement.SelectedOption.GetAttribute("text");
            if (text != actualOptionText)
                throw new Exception($"Expected option not selected: Expected - \"{text}\" was \"{actualOptionText}\"");
        }

        internal void ValidateUrlContainsUri(string uri)
        {
            var url = selenium.Url;

            if (!url.Contains(uri))
                throw new Exception($"Expected uri not present: Expected - \"{uri}\" was \"{url}\"");
        }

        #endregion
    }
}
