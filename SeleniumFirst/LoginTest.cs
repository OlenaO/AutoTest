using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumFirst
{
    public class LoginTest
    {
        [Test]
        public void LoginTest_PassLoginAndPassword_CheckSignIn()
        {
            // !!!Arrange
            IWebDriver driver = new ChromeDriver();
            
            string login = "o.ostapovets@gmail.com";
            string password = "12345678";
            IWebElement element;
            
            string expected = "Exit";

            driver.Navigate().GoToUrl("https://incardoc-test.com/en/PersonalAccount");

            element = driver.FindElement(By.Name("email_sign"));
            element.SendKeys(login);

            element = driver.FindElement(By.Name("password_sign"));
            element.SendKeys(password);

            element = driver.FindElement(By.Id("entry"));
            element.SendKeys(Keys.Enter);

            Thread.Sleep(1000);

            // Act
            var result = driver.FindElement(By.Id("exit")).Text;

            // Assert
            Assert.AreEqual(expected, result);

            //driver.Close();
        }

        [Test]
        public void LoginTest_PassLoginAndInCorrectPassword_CheckError()
        {
            // !!!Arrange
            IWebDriver driver = new ChromeDriver();
            string login = "o.ostapovets@gmail.com";
            string password = "incorrectpass";
            IWebElement element;
            string expected = "Wrong email or password";

            driver.Navigate().GoToUrl("https://incardoc-test.com/en/PersonalAccount");

            element = driver.FindElement(By.Name("email_sign"));
            element.SendKeys(login);

            element = driver.FindElement(By.Name("password_sign"));
            element.SendKeys(password);

            element = driver.FindElement(By.Id("entry"));
            element.SendKeys(Keys.Enter);


            Thread.Sleep(1000);
            // Act
            var result = driver.FindElement(By.ClassName("error")).Text;

            // Assert
            Assert.AreEqual(expected, result);

            //driver.Close();
        }
       
    }
}

