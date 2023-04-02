using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace automatyzacjaTestow
{
    public static class Waits
    {
        public static WebDriverWait Wait;
        private static TimeSpan WaitTimeInSeconds = TimeSpan.FromSeconds(5);

        public static void ElementClickable(this IWebElement element)
        {
            Wait = WebDriverWaitProvider();
            Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void ElementVisible(By locator)
        {
            
            Wait = WebDriverWaitProvider();
            Wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        private static WebDriverWait WebDriverWaitProvider()
        {
            return new WebDriverWait(DriverInstance.GetInstance().GetDriver(), WaitTimeInSeconds);
        }
    }
}

