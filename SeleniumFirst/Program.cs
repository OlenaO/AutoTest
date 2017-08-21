using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        public IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            Console.WriteLine("This project with unit tests. Please run tests in test explorer.");
            Console.ReadKey();
        }

        
    }
}
  