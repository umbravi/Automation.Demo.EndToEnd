using System;
using OpenQA.Selenium;
using Protractor;

namespace Sentinel.Test.EndToEnd.WebDriver
{
    public class Interactions
    {
        private WebDriverPrimitiveMethods _method;

        internal Interactions(WebDriverPrimitiveMethods method)
        {
            this._method = method;
        }

        public void NavigateToUrl(string url)
        {
            Do(() => { _method.NavigateToUrl(url); });
        }

        public void SendTextById(string id, string text)
        {
            Do(() => { _method.SendTextToElement(By.Id(id), text);});
        }

        public void ClickById(string id)
        {
            Do(() => { _method.ClickElement(By.Id(id)); });
        }

        public void ClickByCssSelector(string cssSelector)
        {
            Do(() => { _method.ClickElement(By.CssSelector(cssSelector)); });
        }

        public void ClickByXpath(string xpath)
        {
            Do(() => { _method.ClickElement(By.XPath(xpath)); });
        }

        public void ClickButtonByText(string buttonText)
        {
            Do(() => { _method.ClickElement(By.XPath($"//button[text() = '{buttonText}']")); });
        }

        public void ClickLinkByText(string linkText)
        {
            Do(() => { _method.ClickElement(By.LinkText(linkText)); });
        }

        public void ClickByBinding(string binding)
        {
            Do(() => { _method.ClickElement(NgBy.ExactBinding(binding)); });
        }

        public void ClickByModel(string modelName)
        {
            Do(() => { _method.ClickElement(NgBy.Model(modelName)); });
        }

        public void ValidateUri(string uri)
        {
            Do(() => { _method.ValidateUrlContainsUri(uri); });
        }

        private static void Do(Action singleAnonymousDelegate)
        {
            try
            {
                singleAnonymousDelegate();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failue for reason: {e}");
                throw;
            }
        }
    }
}
