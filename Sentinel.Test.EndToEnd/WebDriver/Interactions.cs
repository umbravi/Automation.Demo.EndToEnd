using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Protractor;

namespace Sentinel.Test.EndToEnd.WebDriver
{
    public class Interactions
    {
        private readonly WebDriverPrimitiveMethods method;

        internal Interactions(WebDriverPrimitiveMethods method)
        {
            this.method = method;
        }

        public void NavigateToUrl(string url)
        {
            Do(() => { method.NavigateToUrl(url); });
        }

        public void SendTextById(string id, string text)
        {
            Do(() => { method.SendTextToElement(By.Id(id), text); });
        }

        public void ClickById(string id)
        {
            Do(() => { method.ClickElement(By.Id(id)); });
        }

        public void ClickByCssSelector(string cssSelector)
        {
            Do(() => { method.ClickElement(By.CssSelector(cssSelector)); });
        }

        public void ClickByXpath(string xpath)
        {
            Do(() => { method.ClickElement(By.XPath(xpath)); });
        }

        public void ClickButtonByText(string buttonText)
        {
            Do(() => { method.ClickElement(By.XPath($"//button[text() = '{buttonText}']")); });
        }

        public void ClickLinkByText(string linkText)
        {
            Do(() => { method.ClickElement(By.LinkText(linkText)); });
        }

        public void ClickByBinding(string binding)
        {
            Do(() => { method.ClickElement(NgBy.ExactBinding(binding)); });
        }

        public void ClickByModel(string modelName)
        {
            Do(() => { method.ClickElement(NgBy.Model(modelName)); });
        }

        public void ValidateUri(string uri)
        {
            Do(() => { method.ValidateUrlContainsUri(uri); });
        }

        public void SelectOptionTextById(string id, string text)
        {
            Do(() => { method.SelectOptionByText(By.Id(id), text); });
        }

        public IList<string> GetOptionsSelectedBySelectId(string questionOneSelectId)
        {
            return DoWithResult(() => method.GetOptionSelectedTextBy(By.Id(questionOneSelectId)));
        }

        public IList<string> GetOptionListBySelectId(string questionOneSelectId)
        {
            return DoWithResult(() => method.GetSelectOptionListTextBy(By.Id(questionOneSelectId)));
        }

        public string GetElementTextByXpath(string xPath)
        {
            return DoWithResult(() => method.GetElementTextBy(By.XPath(xPath)));
        }

        public string GetElementTextByLabelText(string text)
        {
            // xpath for element sibling of label
            //   $"//label[text() = '{text}']/following-sibling::*[1]"
            // xpath for elemet child of label
            //   $"//label[text() = '{text}']/*[1]"
            return GetElementTextByXpath($"//label[text() = '{text}']/following-sibling::*[1]");
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

        private static TResult DoWithResult<TResult>(Func<TResult> singleAnonymousDelegate)
        {
            try
            {
               return singleAnonymousDelegate();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failue for reason: {e}");
                throw;
            }
        }
    }
}
