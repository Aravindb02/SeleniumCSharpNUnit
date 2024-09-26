using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace nunittest.Selenium
{
    internal class ActionExaple
    {
        private IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase()
        {
            IWebElement todayDeal = driver.FindElement(By.XPath("//data-csa-c-id[@data-csa-c-id='md27hl-zgnt8y-d7zo5b-6qfxci']"));
            new Actions(driver).ContextClick(todayDeal).Perform();

            new Actions(driver).DoubleClick(todayDeal).Perform();

            //new Actions(driver).ClickAndHold(Primes).Perform();

            //IWebElement LatestMovies = driver.FindElement(By.XPath(""));
            //new Actions(driver).ClickAndHold(Primes).MoveToElement(LatestMovies).Perform();

            //Drag and Drop


        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
