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
    public class GithubFileCreateRepository
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
        public void TheGithubFileCreateRepositoryTest()
        {
            driver.Navigate().GoToUrl("https://github.com/");
            driver.FindElement(By.XPath("(//img[@alt='@Abdullah-Al-Jubair'])[2]")).Click();
            driver.FindElement(By.LinkText("Your repositories")).Click();
            driver.FindElement(By.LinkText("We-Share")).Click();
            driver.FindElement(By.XPath("//main[@id='js-repo-pjax-container']/div[3]/div/div[2]/div/div[2]/details/summary/span")).Click();
            driver.FindElement(By.XPath("(//button[@type='submit'])[15]")).Click();
            driver.FindElement(By.Name("filename")).Click();
            driver.FindElement(By.Name("filename")).Clear();
            driver.FindElement(By.Name("filename")).SendKeys("qw");
            driver.FindElement(By.Name("filename")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("submit-file")).Click();
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

