using OpenQA.Selenium;

namespace AQATestTask
{
    public class ElementsPage : BasePage
    {
        private static readonly string CheckBoxButtonLocator = "//*[contains(text(), 'Check Box')]/..";

        private IWebElement CheckBoxButton = Driver.GetDriver().FindElement(By.XPath(CheckBoxButtonLocator));

        public ElementsPage(IWebDriver driver) : base(driver) { }

        public CheckBoxPage SwitchToCheckBoxPage()
        {
            CheckBoxButton.Click();

            return new CheckBoxPage(driver);
        }
    }
}