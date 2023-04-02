using OpenQA.Selenium;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace automatyzacjaTestow
{
    public static class DriverUtil
    {
        public static void RefreshPage()
        {
            var driver = DriverInstance.GetInstance().GetDriver();
            driver.Navigate().Refresh();
        }

        public static void SelectAvatar(this IWebElement element, string path)
        {
            element.Click();
            Thread.Sleep(500);
            SendKeys.SendWait(path);
            SendKeys.SendWait(@"{ENTER}");
        }
    }
}