using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using NUnit.Framework;

namespace nunittest.Selenium
{
    internal class Ordering
    {
        private IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            // Login
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            // Add item to cart
            driver.FindElement(By.XPath("//button[contains(text(),'Add to cart')]")).Click();

            // Go to cart
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();

            // Checkout
            driver.FindElement(By.Id("checkout")).Click();

            // Enter checkout information
            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("Doe");
            driver.FindElement(By.Id("postal-code")).SendKeys("12345");
            driver.FindElement(By.Id("continue")).Click();

            // Finish checkout
            driver.FindElement(By.Id("finish")).Click();

            // Verify "Thank you for your order" text
            IWebElement thankYouText = driver.FindElement(By.ClassName("complete-header"));
            Assert.AreEqual("THANK YOU FOR YOUR ORDER", thankYouText.Text, "Order placement failed.");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            
                driver.Close();
         
        }
    }
}
