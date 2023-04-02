using automatyzacjaTestow.Element;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatyzacjaTestow.Pages.ZajeciaStrony
{
    internal class UltimateForms : BaseForm
    {
        public UltimateForms()
        {
            PageFactory.InitElements(DriverInstance.GetInstance().GetDriver(), this);
        }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_message_0")]
        public override IWebElement UniqueElement { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_name_0")]
        public  IWebElement fieldName1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_message_0")]
        public  IWebElement fieldMessage1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_name_1")]
        public  IWebElement fieldName2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_message_1")]
        public IWebElement fieldMessage2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_0 > div.et_pb_contact > form > div > button")]
        public IWebElement btnSubmit1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_1 > div.et_pb_contact > form > div > button")]
        public IWebElement btnSubmit2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_0 > div.et-pb-contact-message > p")]
        public IWebElement msgFillFields1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_1 > div.et-pb-contact-message > p")]
        public IWebElement msgFillFields2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_0 > div > p")]
        public IWebElement msgThanks1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_1 > div > p")]
        public IWebElement msgThanks2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_1 > div.et_pb_contact > form > div > div > p > input")]
        public IWebElement fieldCaptcha { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#et_pb_contact_form_1 > div.et_pb_contact > form > div > div > p > span")]
        public IWebElement textCaptcha { get; set; }

        public void FillForm1(string name, string message)
        {
            WebElementsExtensions.ClearText(fieldName1);
            WebElementsExtensions.ClickElement(fieldName1);
            WebElementsExtensions.EnterText(fieldName1, name);

            WebElementsExtensions.ClearText(fieldMessage1);
            WebElementsExtensions.ClickElement(fieldMessage1);
            WebElementsExtensions.EnterText(fieldMessage1, message);
        }

        public void FillValidForm2(string name, string message, string captcha)
        {
            WebElementsExtensions.ClearText(fieldName2);
            WebElementsExtensions.ClickElement(fieldName2);
            WebElementsExtensions.EnterText(fieldName2, name);

            WebElementsExtensions.ClearText(fieldMessage2);
            WebElementsExtensions.ClickElement(fieldMessage2);
            WebElementsExtensions.EnterText(fieldMessage2, message);

            WebElementsExtensions.ClearText(fieldCaptcha);
            WebElementsExtensions.ClickElement(fieldCaptcha);
            WebElementsExtensions.EnterText(fieldCaptcha, captcha);
        }

        public void FillInvalidForm2(string name, string message, string captcha)
        {
            WebElementsExtensions.ClearText(fieldName2);
            WebElementsExtensions.ClickElement(fieldName2);
            WebElementsExtensions.EnterText(fieldName2, name);

            WebElementsExtensions.ClearText(fieldMessage2);
            WebElementsExtensions.ClickElement(fieldMessage2);
            WebElementsExtensions.EnterText(fieldMessage2, message);

            WebElementsExtensions.ClearText(fieldCaptcha);
            WebElementsExtensions.ClickElement(fieldCaptcha);
            WebElementsExtensions.EnterText(fieldCaptcha, captcha);
        }

    }
}
