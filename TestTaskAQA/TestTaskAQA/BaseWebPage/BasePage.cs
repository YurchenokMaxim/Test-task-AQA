using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AQATestTask
{
    public abstract class BasePage
    {
        public IWebDriver driver => Driver.GetDriver();

        public BasePage(IWebDriver driver)
        {
        }
    }
}
