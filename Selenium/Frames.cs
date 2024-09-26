using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Selenium
{
    internal class Frames
    {
        private IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase()
        {
            Thread.Sleep(1000);
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            driver.SwitchTo().Frame(frame1);
            
            Thread.Sleep(1000);
            
            IWebElement radioButton = driver.FindElement(By.XPath("(//span[@class='ui-checkboxradio-icon ui-corner-all ui-icon ui-icon-background ui-icon-blank'])[1]"));
            
            radioButton.Click();
            Thread.Sleep(1000);

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
