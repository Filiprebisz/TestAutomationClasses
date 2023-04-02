using NUnit.Framework;
using System.Configuration;

namespace automatyzacjaTestow.BaseTestClass
{

    public class BaseTest
    {

        [SetUp]
        public static void SetUp()
        {
            var driver = DriverInstance.GetInstance().GetDriver();
            string url = ConfigurationManager.AppSettings["Url"];
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public static void TearDown()
        {
            DriverInstance.Quit();
        }
    }
}