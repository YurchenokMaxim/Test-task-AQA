using OpenQA.Selenium;

namespace AQATestTask 
{
    public class MainPage : BasePage
    {
        private static readonly string ElementsPageButtonXPath = "//h5[contains(text(), 'Elements')]/../../..";
        private static readonly string MainPageTitle = "ToolsQA";

        private IWebElement ElementsPageButton;

        public MainPage(IWebDriver driver) : base(driver) { }

        public ElementsPage SwitchToElementsPage()
        {
            ElementsPageButton = Driver.GetDriver().FindElement(By.XPath(ElementsPageButtonXPath));
            ElementsPageButton.Click();

            return new ElementsPage(driver);
        }
    }
}