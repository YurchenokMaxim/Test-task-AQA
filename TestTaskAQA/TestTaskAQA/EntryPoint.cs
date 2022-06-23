using OpenQA.Selenium;

namespace AQATestTask
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = Driver.GetDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            MainPage mainPage = new MainPage(driver);

            ElementsPage elementsPage = mainPage.SwitchToElementsPage();
            CheckBoxPage checkBoxPage = elementsPage.SwitchToCheckBoxPage().ClickCheckBox();      
            RadioButtonsPage radioButtonsPage = checkBoxPage.SwitchToTheRadioButtonspage().ClickRadioButtonByName("Impressive")
                .ClickRadioButtonByName("Yes");

            driver.Close();
            driver.Quit();
        }
    }
}