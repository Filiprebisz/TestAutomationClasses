using OpenQA.Selenium;

namespace automatyzacjaTestow
{
    public class DriverInstance
    {
        private static DriverInstance Instance;

        private readonly IWebDriver Driver;

        public DriverInstance()
        {
            Driver = BrowserFactory.GetBrowserDriver();
        }

        public static DriverInstance GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DriverInstance();
            }

            return Instance;
        }

        public IWebDriver GetDriver()
        {
            return Driver;
        }
               
        public static void Quit()
        {
            Instance.Driver.Close();
            Instance.Driver.Quit();
            Instance = null;
        }
    }
}