using automatyzacjaTestow.Element;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace automatyzacjaTestow.Pages
{
    public class SignInPage : BaseForm
    {
        public SignInPage()
        {
            PageFactory.InitElements(DriverInstance.GetInstance().GetDriver(), this);
        }
        [FindsBy(How = How.CssSelector, Using = ".remote-sign-in__vendor-list")]
        public override IWebElement UniqueElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user\\[email\\]")]
        public IWebElement FieldEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user\\[password\\]")]
        public IWebElement FieldPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.button")]
        public IWebElement ButtonSignIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-error__list-item")]
        public IWebElement MsgInvalid { get; set; }

        public void FillForm(string password, string email)
        {
            WebElementsExtensions.ClearText(FieldPassword);
            WebElementsExtensions.ClickElement(FieldPassword);
            WebElementsExtensions.EnterText(FieldPassword, password);

            WebElementsExtensions.ClearText(FieldEmail);
            WebElementsExtensions.ClickElement(FieldEmail);
            WebElementsExtensions.EnterText(FieldEmail, email);

        }
    }
}
