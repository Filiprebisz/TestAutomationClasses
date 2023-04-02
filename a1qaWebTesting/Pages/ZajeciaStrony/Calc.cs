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
    public class CalcPage : BaseForm
    {
        public CalcPage()
        {
            PageFactory.InitElements(DriverInstance.GetInstance().GetDriver(), this);
        }
        [FindsBy(How = How.CssSelector, Using = "#inputhelper")]
        public override IWebElement UniqueElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#precmpdialog > div > div > div.modal-body > form > div > div:nth-child(2) > button")]
        public IWebElement BtnConsent { get; set; }
        [FindsBy(How = How.CssSelector, Using = "body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p")]
        public IWebElement BtnConsent2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn0")]
        public IWebElement Btn0 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn1")]
        public IWebElement Btn1 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn2")]
        public IWebElement Btn2 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn3")]
        public IWebElement Btn3 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn4")]
        public IWebElement Btn4 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn5")]
        public IWebElement Btn5 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn6")]
        public IWebElement Btn6 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn7")]
        public IWebElement Btn7 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn8")]
        public IWebElement Btn8 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Btn9")]
        public IWebElement Btn9 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BtnMinus")]
        public IWebElement BtnMinus { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BtnPlus")]
        public IWebElement BtnPlus { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BtnMult > span:nth-child(1)")]
        public IWebElement BtnMult { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BtnDiv > span:nth-child(1)")]
        public IWebElement BtnDiv { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BtnCalc")]
        public IWebElement BtnCalc { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BtnClear")]
        public IWebElement BtnClear { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#input")]
        public IWebElement FieldValue { get; set; }


    }
}

