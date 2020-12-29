using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class A3Testing
    {


        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();                                                            // Opening the browser.
        }
        [Test]
        public void test()
        {

            driver.Url = "https://www.iutoic-dhaka.edu/campus_life/discover_iut";                    // Cicking in the IUT website for going to "Discover_IUT" page.
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='app']/div[3]/div[1]/div/div[1]/ul/li[1]/a"));   // Will Ridirect to Admission Page
            element1.Click();                                                                       // Cicking in the IUT website for going to "Research" page.
            
            driver.Navigate().Back();                                                               // For going back to the previous page
            driver.Navigate().Forward();                                                            // For going back to Forward Apge
            driver.Navigate().Refresh();




        }

        /*[TearDown]
        public void closeBrowser()
        {
            driver.Close();               //Closing the Browser
        }*/


    }
}
