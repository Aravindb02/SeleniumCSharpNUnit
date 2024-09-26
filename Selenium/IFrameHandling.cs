using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class IFrameHandling
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            // Configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // Initialize web driver
            driver = new ChromeDriver();
            // Launch chrome browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestCase1()
        {
            Thread.Sleep(1000);
            driver.SwitchTo().Frame("mce_0_ifr");
            IWebElement textArea = driver.FindElement(By.Id("tinymce"));
            textArea.Clear();
            textArea.SendKeys("hello");
            Thread.Sleep(2000);
            

            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
