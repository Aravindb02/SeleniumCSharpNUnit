using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class TableHandling
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            // xpath of the html web table

            IWebElement table = driver.FindElement(By.XPath("//table[@id = 'table1']"));

            // fetch the all rows of the table

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr")));

            int rowcount = trrow.Count();

            Console.WriteLine(rowcount);

            // fecth the no of columns

            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td")));

            int colcount = tdcol.Count();

            Console.WriteLine(colcount);

            // cell data

            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[2]/td[2]"));

            string text = celldata.Text;

            Console.WriteLine(text);

            Assert.AreEqual("Frank", text);
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

     
    }
}