using OpenQA.Selenium;

namespace AQATestTask
{
    public class Driver
    {
        private static Driver _currentInstance;
        private static IWebDriver _driver = DriverFactory.CreateDriver(_browser);
        public static string _currentBrowser;
        public static int _implicitWait;
        public static double _timeoutForElement;
        private static string _browser = "Chrome";

        private Driver() { }

        public static Driver Instance
        {
            get
            {
                var browser = _currentInstance;

                if (browser != null)
                {
                    return browser;
                }

                return _currentInstance = new Driver();
            }
        }

        public static void WindowMaximize()
        {
            _driver.Manage().Window.Maximize();
        }


        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void Quit()
        {
            _driver.Quit();
            _currentInstance = null;
            _browser = null;
        }
    }
}