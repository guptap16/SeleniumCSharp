using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace MortgageCadenceDemo.BaseTest
{
    public class BaseTest
    {
        public static IWebDriver driver;

        [SetUp]

        public void GoToPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://interview-contact-us.azurewebsites.net/";
            Thread.Sleep(2000);
        }

        [TearDown]

        public void QuitePage() => driver.Quit();
    }
}
