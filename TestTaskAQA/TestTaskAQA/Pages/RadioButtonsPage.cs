using OpenQA.Selenium;

namespace AQATestTask
{
    public class RadioButtonsPage : BasePage
    {
        public RadioButtonsPage(IWebDriver driver) : base(driver) { }

        public RadioButtonsPage ClickRadioButtonByName(string nameOfButton)
        {
            Driver.GetDriver().FindElement(By.XPath("//label[contains(text(), '" + nameOfButton + "')]")).Click();

            return new RadioButtonsPage(driver);
        }
    }
}