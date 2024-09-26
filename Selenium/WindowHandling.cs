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
    internal class WindowHandling
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestCase1()
        {
            Thread.Sleep(1000);
            String currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            IWebElement openNewWindow = driver.FindElement(By.LinkText("Click Here"));
            openNewWindow.Click();

            Thread.Sleep(2000);

            IList<String> windowHandles = new List<String>(driver.WindowHandles);

            driver.SwitchTo().Window(windowHandles[1]);

            Thread.Sleep(2000);

            String newWindowTitle = driver.Title;
            Console.WriteLine(newWindowTitle);
            Assert.AreEqual("New Window", newWindowTitle);

            Thread.Sleep(2000);

            driver.Close();

            Thread.Sleep(1000);

            driver.SwitchTo().Window(windowHandles[0]);

            Thread.Sleep(1000);

           
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}

