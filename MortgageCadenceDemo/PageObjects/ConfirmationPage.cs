using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCadenceDemo.PageObjects
{
    public class ConfirmationPage
    {
        IWebDriver driver;
        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public IWebElement ConfirmationMsg => driver.FindElement(By.CssSelector("p.text-center"));

        public string getConfirmationMsg()
        {
            return ConfirmationMsg.Text;
        }

    }
}
