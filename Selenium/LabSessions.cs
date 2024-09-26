using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Selenium
{
    internal class LabSessions
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.cavai.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement headerElement = driver.FindElement(By.XPath("//div[contains(text(), 'Sign in')]"));
            Assert.That(headerElement, Is.Not.Null);
            headerElement.Click();

            IWebElement paraTextElem = driver.FindElement(By.XPath("//p[starts-with(@class, 'CavaiFor_row__text_')]"));
            Assert.That(paraTextElem, Is.Not.Null);
            headerElement.Click();

            //IWebElement endswith = driver.FindElement(By.XPath(("")));
        }
        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
