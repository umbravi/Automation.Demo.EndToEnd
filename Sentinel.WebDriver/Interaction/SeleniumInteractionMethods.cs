using OpenQA.Selenium;
using Protractor;
using Sentinel.WebDriver.Interaction.Selenium;

namespace Sentinel.WebDriver.Interaction
{
    public class SeleniumInteractionMethods
    {
        private readonly IWebDriver selenium;
        private readonly NgWebDriver protractor;

        internal SeleniumValidationInteractions Validations { get; }
        internal SeleniumGetInteractions Gets { get; }
        internal SeleniumActionInteractions Actions { get; }

        public SeleniumInteractionMethods(IWebDriver selenium, NgWebDriver protractor)
        {
            this.selenium = selenium;
            this.protractor = protractor;
            Validations = new SeleniumValidationInteractions(selenium, protractor);
            Gets = new SeleniumGetInteractions(selenium, protractor);
            Actions = new SeleniumActionInteractions(selenium, protractor);
        }
    }
}