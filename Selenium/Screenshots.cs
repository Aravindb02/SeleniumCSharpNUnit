using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class TakeScreenShot
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            //Take Screensot class and getscreenshotAs method
            Screenshot ss = driver.TakeScreenshot();
            ss.SaveAsFile("C:\\Users\\arach\\Desktop\\screenshot\\test.jpg");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}