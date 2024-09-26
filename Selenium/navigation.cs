using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Selenium
{
    internal class navigation
    {
        private IWebDriver driver;
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void TestCase1()
        {
            //goto url
            StartBrowser();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            driver.Navigate().Back();
            Thread.Sleep(3000);

            driver.Navigate().Forward();
            Thread.Sleep(3000);

            driver.Navigate().Refresh();
            Thread.Sleep(3000);
        }
         
        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
