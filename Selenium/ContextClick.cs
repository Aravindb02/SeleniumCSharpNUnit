using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Selenium
{
    internal class ContextClick
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

                driver.Navigate().GoToUrl("https://www.amazon.in/");
                driver.Manage().Window.Maximize();
            }

            [Test]
            public void testcase1()
            {
                IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

                new Actions(driver)
                  .ContextClick(TdyDeal)
                  .Perform();
                Thread.Sleep(1000);
            }

            [TearDown]
            public void tearDownbrowser()
            {

                driver.Close();

            }

        
    }
}
