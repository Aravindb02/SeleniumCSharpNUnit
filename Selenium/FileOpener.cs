using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;


namespace NUnitSeleniumCSharp.Selenium
{
    internal class FileOpener
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {



            IWebElement file = chromeDriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/a[1]"));
            file.Click();

            string text = file.Text;
            string path = "C:\\Users\\arach\\Downloads\\"+ text;
            Console.WriteLine(path);
            Assert.That(File.Exists(path));

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}

