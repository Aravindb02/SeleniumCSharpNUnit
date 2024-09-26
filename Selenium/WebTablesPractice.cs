using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace nunittest.Selenium
{
    internal class WebTablesPractice
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
            public void FBUsernameAction()

            {
                IWebElement table = driver.FindElement(By.XPath("//table[@name = 'courses']"));


                List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("//table[@class='table-display']/tbody/tr")));

                int rowCount = tr.Count();
                Console.WriteLine(rowCount + "row number");

                List<IWebElement> td = new List<IWebElement>(table.FindElements(By.XPath("//table[@class='table-display']/tbody/tr[1]/td")));

                int columnCount = td.Count();
                Console.WriteLine(columnCount + "Column number");

                IWebElement cellData = driver.FindElement(By.XPath("//table[@class='table-display']/tbody/tr[8]/td[2]"));
                string textData = cellData.Text;
                Console.WriteLine(cellData.Text);
                Assert.That(textData, Is.EqualTo("QA Expert Course :Software Testing + Bugzilla + SQL + Agile"));

            

        }

            [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}












//int cnt = 0;
//foreach (var i in table.FindElements(By.XPath("//table[@class='table-display']/tbody/tr")))
//{

//    foreach (var j in i.FindElements(By.XPath($"//table[@class='table-display']/tbody/tr[{cnt++}]/td")))
//    {
//        Console.Write(j.Text + " - ");
//    }
//    Console.WriteLine();
//}
