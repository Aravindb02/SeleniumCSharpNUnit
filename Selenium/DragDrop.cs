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
    internal class DragDrop
    {
        private IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void TestCase() {
            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));
            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-a']"));
            Thread.Sleep(1000);
            new Actions(driver).DragAndDrop(Source, Dest).Perform();
            Thread.Sleep(1000);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
