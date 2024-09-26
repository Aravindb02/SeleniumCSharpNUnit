using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace nunittest.Selenium
{
    internal class KeyboardActions
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

            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void KeysDown()
        {
            new Actions(driver).KeyDown(Keys.Shift).SendKeys("a").Perform();
            Thread.Sleep(2000);

            new Actions(driver).KeyUp(Keys.Shift).SendKeys("A").Perform();
            Thread.Sleep(2000);

            new Actions(driver).KeyDown(Keys.Control).SendKeys("c").Perform();
            Thread.Sleep(2000);

            // Simulate paste action (Ctrl+V)
            new Actions(driver).KeyDown(Keys.Control).SendKeys("v").Perform();
            Thread.Sleep(6000);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close(); 
        }
        
    }
}
