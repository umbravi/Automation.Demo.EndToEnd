using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Protractor;

namespace Sentinel.WebDriver.Interaction
{
    public class BrowserInteraction
    {
        private readonly SeleniumInteractionMethods method;

        public BrowserInteraction(SeleniumInteractionMethods method)
        {
            this.method = method;
        }

        public void NavigateToUrl(string url)
        {
            Do(() => { method.Actions.NavigateToUrl(url); });
        }

        public void SendTextById(string id, string text)
        {
            Do(() => { method.Actions.SendTextToElement(By.Id(id), text); });
        }

        public void ClickById(string id)
        {
            Do(() => { method.Actions.ClickElement(By.Id(id)); });
        }

        public void ClickByCssSelector(string cssSelector)
        {
            Do(() => { method.Actions.ClickElement(By.CssSelector(cssSelector)); });
        }

        public void ClickByXpath(string xpath)
        {
            Do(() => { method.Actions.ClickElement(By.XPath(xpath)); });
        }

        public void ClickButtonByText(string buttonText)
        {
            Do(() => { method.Actions.ClickElement(By.XPath($"//button[text() = '{buttonText}']")); });
        }

        public void ClickLinkByText(string linkText)
        {
            Do(() => { method.Actions.ClickElement(By.LinkText(linkText)); });
        }

        public void ClickByBinding(string binding)
        {
            Do(() => { method.Actions.ClickElement(NgBy.ExactBinding(binding)); });
        }

        public void ClickByModel(string modelName)
        {
            Do(() => { method.Actions.ClickElement(NgBy.Model(modelName)); });
        }

        public void ValidateUri(string uri)
        {
            Do(() => { method.Validations.ValidateUrlContainsUri(uri); });
        }

        public void SelectOptionTextById(string id, string text)
        {
            Do(() => { method.Actions.SelectOptionByText(By.Id(id), text); });
        }

        public IList<string> GetOptionsSelectedBySelectId(string questionOneSelectId)
        {
            return DoWithResult(() => method.Gets.GetOptionSelectedTextBy(By.Id(questionOneSelectId)));
        }

        public IList<string> GetOptionListBySelectId(string questionOneSelectId)
        {
            return DoWithResult(() => method.Gets.GetSelectOptionListTextBy(By.Id(questionOneSelectId)));
        }

        public string GetElementTextByXpath(string xPath)
        {
            return DoWithResult(() => method.Gets.GetElementTextBy(By.XPath(xPath)));
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
                Console.WriteLine($@"Failue for reason: {e}");
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
                Console.WriteLine($@"Failue for reason: {e}");
                throw;
            }
        }
    }
}
