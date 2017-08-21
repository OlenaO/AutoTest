using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Test
    {

        // Create the reference for our brouther
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            //navigate to Google page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            Thread.Sleep(1000);
            //Title
            seleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            Thread.Sleep(1000);
            //Initial
            seleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");




            Thread.Sleep(1000);
            //Click
            seleniumSetMethods.Click(driver, "Save", "Name", "Name");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }
        [TearDown]
        public void CleanUp()
        {

            driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
