using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Protractor;
using Sentinel.WebDriver.Interaction;
using Sentinel.WebDriver.Resource;

namespace Sentinel.WebDriver
{
    public class BrowserDriver
    {
        private IWebDriver Selenium;
        private NgWebDriver Protractor;

        public BrowserInteraction Interactions;
        
        public BrowserDriver(string webBrowserToOpen)
        {
            switch (webBrowserToOpen.ToUpper())
            {
                case "CHROME":
                    DriverResourceHelper.CreateChromeDriver();
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("start-maximized");
                    Selenium = new ChromeDriver(chromeOptions);
                    break;
                case "FIREFOX":
                    DriverResourceHelper.CreateFirefoxDriver();
                    Selenium = new FirefoxDriver();
                    break;
                case "INTERNETEXPLORER":
                case "IE":
                    DriverResourceHelper.CreateIeDriver();
                    var ieOptions = new InternetExplorerOptions
                    {
                        IgnoreZoomLevel = true,
                        EnableNativeEvents = false
                    };

                    Selenium = new InternetExplorerDriver(ieOptions);
                    break;
                case "EDGE":
                    DriverResourceHelper.CreateEdgeDriver();
                    Selenium = new EdgeDriver();
                    break;
                default:
                    throw new Exception($"Unknown or unlisted web browser: {webBrowserToOpen}");
            }

            Protractor = new NgWebDriver(Selenium);

            Selenium.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            Interactions = new BrowserInteraction(new SeleniumInteractionMethods(Selenium, Protractor));
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
