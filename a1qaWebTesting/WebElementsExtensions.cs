using Fare;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace automatyzacjaTestow.Element
{
    public static class WebElementsExtensions
    {

        // Interaction methods
        public static void EnterText(this IWebElement element, string value)
        {
            Waits.ElementClickable(element);
            element.SendKeys(value);
        }

        public static void ClickElement(this IWebElement element)
        {
            Waits.ElementClickable(element);
            element.Click();
        }

        public static void ClearText(this IWebElement element)
        {
            Waits.ElementClickable(element);
            element.Clear();
        }


        // Get methods
        public static string GetValue(this IWebElement element)
        {
            Waits.ElementClickable(element);
            return element.GetAttribute("value");
        }

        public static string GetPlaceholderValue(this IWebElement element)
        {
            Waits.ElementClickable(element);
            return element.GetAttribute("placeholder");
        }


        public static string GetText(WebDriverWait wait, By locator)
        {
            var driver = DriverInstance.GetInstance().GetDriver();
            Waits.ElementVisible(locator);

            if (locator != null)
                return wait.Until(e => e.FindElement(locator).Text);
            else return string.Empty;
        }

        public static string GetTitle() => DriverInstance.GetInstance().GetDriver().Title;


        // Generate methods
        private static string GeneratePassword(bool validPassword)
        {
            var randomizerText = RandomizerFactory.GetRandomizer(
                new FieldOptionsText
                {
                    UseLowercase = true,
                    UseUppercase = true,
                    UseNumber = true,
                    UseSpecial = false,
                    Min = validPassword ? 10 : 5,
                    Max = validPassword ? 10 : 9
                });
            return randomizerText.Generate();
        }
        public static string GenerateValidPassword(this IWebElement element) => GeneratePassword(true);
        public static string GenerateInvalidPassowrd(this IWebElement element) => GeneratePassword(false);

        //Validate methods

        public static bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static string CalculateCaptcha(IWebElement element)
        {
            string equation = element.Text;
            string[] digits = equation.Split('+');

            int firstDigit = int.Parse(digits[0]);
            int secondDigit = int.Parse(digits[1]);

            int result = firstDigit + secondDigit;
            string resultString = result.ToString();

            return resultString;
        }

    }
}