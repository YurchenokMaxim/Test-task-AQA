using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AQATestTask
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver(string driver)
        {
            IWebDriver webDriver = null;

            switch (driver)
            {
                case "Firefox":
                    {
                        try
                        {
                            new DriverManager().SetUpDriver(new FirefoxConfig());
                            webDriver = new FirefoxDriver();
                            SetDriverParams(webDriver);

                            return webDriver;
                        }
                        catch
                        {
                            throw new Exception("Firefox web driver wasn't created.");
                        }
                    }
                case "Edge":
                    {
                        try
                        {
                            new DriverManager().SetUpDriver(new EdgeConfig());
                            webDriver = new EdgeDriver();
                            SetDriverParams(webDriver);

                            return webDriver;
                        }
                        catch
                        {
                            throw new Exception("Edge web driver wasn't created.");
                        }
                    }
                default:
                    {
                        try
                        {
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            webDriver = new ChromeDriver();
                            SetDriverParams(webDriver);

                            return webDriver;
                        }
                        catch
                        {
                            throw new Exception("Chrome web driver wasn't created.");
                        }
                    }
            }
        }

        private static void SetDriverParams(IWebDriver driver)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Manage().Window.Maximize();
        }
    }
}
