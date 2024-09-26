using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Selenium
{
    internal class LauchEdge
    {
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            EdgeDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
        }
        [Test]
        public void TestCase1()
        {

        }
    }
}
