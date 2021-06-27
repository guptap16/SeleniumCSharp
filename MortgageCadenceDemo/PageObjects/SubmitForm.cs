using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MortgageCadenceDemo.PageObjects
{
    class SubmitForm
    {

        IWebDriver driver;
        public  SubmitForm(IWebDriver driver)
        {
            this.driver = driver;
            
        }

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));

        public IWebElement LastName => driver.FindElement(By.Id("lastName"));

        public IWebElement Email => driver.FindElement(By.Id("email"));

        public IWebElement Address => driver.FindElement(By.Id("address"));

        public IWebElement Country => driver.FindElement(By.Id("country"));

        public IWebElement State => driver.FindElement(By.Id("state"));

        public IWebElement Zip => driver.FindElement(By.Id("zip"));

        public IWebElement SubmitBtn => driver.FindElement(By.CssSelector("button.w-100.btn.btn-primary.btn-lg"));

        public void   Click_Submit_Btn()
        {
            FirstName.SendKeys("Jane");
            Thread.Sleep(1000);

            LastName.SendKeys("Doe");
            Thread.Sleep(1000);

            Email.SendKeys("Jane.Doe@test.com");
            Thread.Sleep(1000);

            Address.SendKeys("123 Downton Abbey");
            Thread.Sleep(1000);

            SelectElement SelectCountry = new SelectElement(Country);
            SelectCountry.SelectByText("United States");
            Thread.Sleep(1000);

            SelectElement SelectState = new SelectElement(State);
            SelectState.SelectByText("California");
            Thread.Sleep(1000);

            Zip.SendKeys("28277");
            Thread.Sleep(2000);

            SubmitBtn.Click();
            Console.WriteLine("Submit Button is clicked");
                        





        }

        
    }
}
