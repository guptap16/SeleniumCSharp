// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using OpenQA.Selenium.Support.PageObjects;
using MortgageCadenceDemo.PageObjects;
using System.Threading;

namespace MortgageCadenceDemo.BaseTest
{
    [TestFixture]
    public class ContactUs : BaseTest
    {
        [Test]
        public void Test()
        {
            var submitForm = new SubmitForm(driver);
            submitForm.Click_Submit_Btn();
            Thread.Sleep(5000);
            var confirmationPage = new ConfirmationPage(driver);
            String actualConfirmationMsg = confirmationPage.getConfirmationMsg();
            String expectedConfirmationMsg = "Thank you for your interest! Once we review your request a representative will be in contact with you.";
            Assert.IsTrue(actualConfirmationMsg.Equals(expectedConfirmationMsg));
            Thread.Sleep(5000);

        }



    }

    }

