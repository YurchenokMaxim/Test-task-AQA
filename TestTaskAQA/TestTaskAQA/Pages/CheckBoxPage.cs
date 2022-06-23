using OpenQA.Selenium;

namespace AQATestTask
{
    public class CheckBoxPage : BasePage
    {
        private static readonly string CheckBoxClassName = "rct-checkbox";
        private static readonly string RadioButtonsButtonLocator = "//*[contains(text(), 'Radio Button')]/..";

        private IWebElement RadioButtonsButton = Driver.GetDriver().FindElement(By.XPath(RadioButtonsButtonLocator));
        private IWebElement CheckBox = Driver.GetDriver().FindElement((By.ClassName(CheckBoxClassName)));

        public CheckBoxPage(IWebDriver driver) : base(driver) { }

        public CheckBoxPage ClickCheckBox()
        {
            CheckBox.Click();

            return this;
        }

        public RadioButtonsPage SwitchToTheRadioButtonspage()
        {
            RadioButtonsButton.Click();

            return new RadioButtonsPage(driver);
        }
    }
}