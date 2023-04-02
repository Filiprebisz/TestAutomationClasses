using NUnit.Framework;
using automatyzacjaTestow.Element;
using automatyzacjaTestow.BaseTestClass;
using automatyzacjaTestow.Pages;
using System.IO;
using OpenQA.Selenium;
using System.Threading;
using System.Diagnostics;
using automatyzacjaTestow.Pages.ZajeciaStrony;
using System;
using OpenQA.Selenium.Support.UI;

namespace automatyzacjaTestow
{
    class TestClass
    {
        static void Main(string[] args)
        {
        }
    }

    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        public void OutForms()
        {
            UltimateForms forms = new UltimateForms();

            string tmpStr = WebElementsExtensions.GetTitle();
            Assert.That(tmpStr == "Filling Out Forms - Ultimate QA", "Wrong page opened");

            Assert.That(WebElementsExtensions.GetPlaceholderValue(forms.fieldName1) == "Name", "Wrong placeholder value");

            Assert.That(WebElementsExtensions.GetPlaceholderValue(forms.fieldMessage1) == "Message", "Wrong placeholder value");

            Assert.That(forms.btnSubmit1.Text == "Submit", "Wrong button text");
            forms.btnSubmit1.ClickElement();

            Assert.That(forms.msgFillFields1.Text == "Make sure you fill in all required fields.", "Message did not display");

            forms.FillForm1("Testname", "Testmessage");
            Assert.That(forms.fieldName1.GetValue() == "Testname");
            Assert.That(forms.fieldMessage1.GetValue() == "Testmessage");

            forms.btnSubmit1.ClickElement();
            Thread.Sleep(3000);
            Assert.That(forms.msgThanks1.Text == "Thanks for contacting us", "Message did not display");
            Assert.IsFalse(WebElementsExtensions.IsElementDisplayed(forms.btnSubmit1));

            Assert.IsTrue(forms.fieldCaptcha.Displayed);

            Assert.That(WebElementsExtensions.GetPlaceholderValue(forms.fieldName2) == "Name", "Wrong placeholder value");

            Assert.That(WebElementsExtensions.GetPlaceholderValue(forms.fieldMessage2) == "Message", "Wrong placeholder value");

            Assert.That(forms.btnSubmit2.Text == "Submit", "Wrong button text");
            forms.btnSubmit2.ClickElement();

            Assert.That(forms.msgFillFields2.Text == "Please, fill in the following fields:", "Message did not display");

            forms.FillInvalidForm2("", "", "1");
            Assert.That(forms.fieldName2.GetValue() == "");
            Assert.That(forms.fieldMessage2.GetValue() == "");
            Assert.That(forms.fieldCaptcha.GetValue() == "1");
            Assert.That(forms.msgFillFields2.Text == "Please, fill in the following fields:", "Message did not display");

            
            forms.FillInvalidForm2("Nametest", "Messagetest", WebElementsExtensions.CalculateCaptcha(forms.textCaptcha));
            Assert.That(forms.fieldName2.GetValue() == "Nametest");
            Assert.That(forms.fieldMessage2.GetValue() == "Messagetest");
            Assert.That(forms.fieldCaptcha.GetValue() == WebElementsExtensions.CalculateCaptcha(forms.textCaptcha));
            forms.btnSubmit2.ClickElement();
            Thread.Sleep(3000);
            Assert.That(forms.msgThanks2.Text == "Thanks for contacting us", "Message did not display");
            
        }
    }
}