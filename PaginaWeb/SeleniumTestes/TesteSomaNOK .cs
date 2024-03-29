using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class ClassSomaNOK
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        //private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new FirefoxDriver();
            //baseURL = "https://www.katalon.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void SomandoTesteNOK()
        {
            driver.Navigate().GoToUrl("http://carloslaranjeirajr1.gearhostpreview.com/index.aspx");
            driver.FindElement(By.Id("TextBoxPrimeiroNumero")).Click();
            driver.FindElement(By.Id("TextBoxPrimeiroNumero")).Clear();
            driver.FindElement(By.Id("TextBoxPrimeiroNumero")).SendKeys("4");
            driver.FindElement(By.Id("TextBoxSegundoNumero")).Click();
            driver.FindElement(By.Id("TextBoxSegundoNumero")).Clear();
            driver.FindElement(By.Id("TextBoxSegundoNumero")).SendKeys("5");
            driver.FindElement(By.Id("ButtonCalcular")).Click();
            try
            {
                Assert.AreEqual("10", driver.FindElement(By.Id("LabelResultado")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.Close();
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
