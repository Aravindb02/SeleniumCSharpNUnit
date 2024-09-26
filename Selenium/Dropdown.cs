using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using AngleSharp.Html;
using OpenQA.Selenium.Support.UI;

namespace nunittest.Selenium
{
    internal class Dropdown
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            // store the list of checkboxes
            IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);
            var select =new SelectElement(DropDown);
            
            Thread.Sleep(2000);
            select.SelectByText("Option2");

            Thread.Sleep(2000);
            select.SelectByIndex(1);
            
            Thread.Sleep(2000);
            select.SelectByValue("option3");

        }

        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close();
        }
    }
}
