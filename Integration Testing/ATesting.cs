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
    class ATesting
    {

        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();                   //Browser will be opened.
        }
        [Test]
        public void test()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";      //Destination URL
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='username']"));   //Insert Student ID here.
            element1.SendKeys("170042030");
            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='password']"));   //Insert your password here
            element2.SendKeys("*******");                                           
            IWebElement element3 = driver.FindElement(By.XPath("//*[@id='loginbtn']"));    // Clicking on the Log In Button
            element3.Click();
        }

        [TearDown]
        public void closeBrowser()              //Close the browser.
        {
            driver.Close();
        }


    }
}
