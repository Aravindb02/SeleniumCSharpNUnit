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
    internal class SauceDemo
    {
        ChromeDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void Testcase1()
        {
            Thread.Sleep(2000);

            IWebElement Username = driver.FindElement(By.Id("user-name"));
            Username.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");

            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));
            LoginButton.Click();
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Browser closed");
            driver.Close();
        }
    }
}
