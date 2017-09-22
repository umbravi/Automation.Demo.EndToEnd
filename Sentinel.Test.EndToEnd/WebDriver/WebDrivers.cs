using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Protractor;

namespace Sentinel.Test.EndToEnd.WebDriver
{
    public class WebDrivers
    {
        internal IWebDriver Selenium;
        internal NgWebDriver Protractor;

        internal Interactions Interactions;

        //ToDo: Add Edge
        public WebDrivers(string webBrowserToOpen)
        {
            if (webBrowserToOpen.ToUpper() == "CHROME")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("start-maximized");
                Selenium = new ChromeDriver(chromeOptions);
            }
            else if (webBrowserToOpen.ToUpper() == "FIREFOX")
            {
                Selenium = new FirefoxDriver();
            }
            else if (webBrowserToOpen.ToUpper() == "INTERNETEXPLORER" || webBrowserToOpen.ToUpper() == "IE")
            {
                var ieOptions = new InternetExplorerOptions
                {
                    IgnoreZoomLevel = true,
                    EnableNativeEvents = false
                };

                Selenium = new InternetExplorerDriver(ieOptions);
            }
            else
            {
                throw new Exception($"Unknown or unlisted web browser: {webBrowserToOpen}");
            }

            Protractor = new NgWebDriver(Selenium);

            Selenium.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            Interactions = new Interactions(new WebDriverPrimitiveMethods(Selenium, Protractor));
        }

        public void KillDrivers()
        {
            Selenium.Close();
            Selenium.Quit();
            Selenium = null;
            Protractor = null;
        }
    }
}
