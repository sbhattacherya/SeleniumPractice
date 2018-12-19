using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SeleniumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Selenium\ChromeDriver");
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Quit();
        }
    }
}
