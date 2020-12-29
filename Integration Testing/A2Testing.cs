using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class A2Testing
    {


        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();            // Opening the browser.
        }
        [Test]
        public void test()
        {
            driver.Url = "https://www.iutoic-dhaka.edu/";
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='app']/header/div[3]/div/ul/li[3]/a"));
            element1.Click();                       // Cicking in the IUT website for going to "Research" page.
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();               //Closing the Browser
        }



    }
}
