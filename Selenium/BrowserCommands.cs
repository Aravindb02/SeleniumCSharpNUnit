using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace nunittest.Selenium
{
    internal class BrowserCommands
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
            
            //title
            string title = driver.Title;
            Console.WriteLine(title);

            //current
            string currentUrl = driver.Url;
            Console.WriteLine(currentUrl);

            //pagesource
            string pageSource = driver.PageSource;
            Console.WriteLine(pageSource);



        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
