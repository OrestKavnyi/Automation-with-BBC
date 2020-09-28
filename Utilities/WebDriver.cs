using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject.Utilities
{
    public static class WebDriver //Singleton (also not a fully correct version as we try to prevent instantiating of other class)
    {
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                }
                return driver;
            }
            private set { driver = value; }
        }
        public static void Reset()
        {
            Driver.Quit();
            Driver = null;
        }
    }
}