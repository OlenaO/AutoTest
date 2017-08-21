using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class seleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if(value =="Id")
            driver.FindElement(By.Id(element));
            if (value == "Name")
                driver.FindElement(By.Name(element));
        }

        //Click into a button, Checkbox, option
        public static void Click(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
               new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
