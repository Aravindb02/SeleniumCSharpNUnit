using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class FacebookLogin
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
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Keydown()
        {

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("aravind").Perform();
            Thread.Sleep(2000);


            new Actions(driver).KeyUp(Keys.Shift).KeyDown(Keys.Tab).KeyDown(Keys.Shift).SendKeys("bigwing").Perform();
            Thread.Sleep(2000);

            
            Thread.Sleep(2000);

           
            
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}