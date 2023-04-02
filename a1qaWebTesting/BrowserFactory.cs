using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace automatyzacjaTestow
{
    public class BrowserFactory
    {
        public static IWebDriver GetBrowserDriver()
        {
            string driverName = ConfigurationManager.AppSettings["Browser"].ToLower();
           
            switch (driverName)
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                default:
                    throw new ArgumentException("Browser name is incorrect");
            }
        }
    }
}