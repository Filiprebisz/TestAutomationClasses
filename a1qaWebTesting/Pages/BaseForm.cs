using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace automatyzacjaTestow.Pages
{
    public abstract class BaseForm
    {
        public abstract IWebElement UniqueElement { get; set; }

        public virtual bool IsDisplayed() => UniqueElement.Displayed;
    }
}
