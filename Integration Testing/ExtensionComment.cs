using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace SeleniumTests
{
    [TestFixture]
    public class ExtensionComment
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheExtensionCommentTest()
        {
            driver.Navigate().GoToUrl("https://elp.duetbd.org/login/index.php");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("*******");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("170042030");
            driver.FindElement(By.Id("loginbtn")).Click();
            driver.FindElement(By.XPath("//div[@id='nav-drawer']/nav/ul/li[4]/a/div/div/span[2]")).Click();
            driver.FindElement(By.XPath("//a[@id='message-user-button']/span/i")).Click();
            driver.FindElement(By.Id("yui_3_17_2_1_1609744284705_373")).Click();
            driver.FindElement(By.Id("yui_3_17_2_1_1609744035439_373")).Clear();
            driver.FindElement(By.Id("yui_3_17_2_1_1609744035439_373")).SendKeys("Hello Testing");
            driver.FindElement(By.XPath("//button[@id='yui_3_17_2_1_1609742559474_391']/span/i")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
