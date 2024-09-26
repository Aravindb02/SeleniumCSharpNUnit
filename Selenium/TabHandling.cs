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
    internal class TagHandling
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            //Fetch the handle of the parent page

            String currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            //Click on the link to open the new window
            IWebElement Open = driver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            Open.Click();

            Thread.Sleep(2000);

            //Fetch the window handles of all windows there will be two window opened
            IList<String> windowHandles = new List<String>(driver.WindowHandles);

            // The control is moved to child window
            driver.SwitchTo().Window(windowHandles[1]);

            Thread.Sleep(2000);

            String title = driver.Title;
            Console.WriteLine(title);
            Assert.AreEqual("Simple Page", title);

            Thread.Sleep(2000);

            //Closing of the child window
            driver.Close();

            Thread.Sleep(1000);

            driver.SwitchTo().Window(windowHandles[0]);

            Thread.Sleep(1000);

            String title1 = driver.Title;
            Console.WriteLine(title1);
            Assert.AreEqual("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow", title1);

            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}