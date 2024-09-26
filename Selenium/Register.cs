using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Selenium
{
    internal class Register
    {
        ChromeDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
        }

        [Test]
        public void Testcase1()
        {
            Thread.Sleep(2000);
            

            IWebElement Gender = driver.FindElement(By.Id("gender-male"));
            Gender.Click();

            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
            FirstName.SendKeys("John");

            IWebElement LastName = driver.FindElement(By.Id("LastName"));
            LastName.SendKeys("Cena");

            IWebElement Email = driver.FindElement(By.Id("Email"));
            Email.SendKeys("johncena@gmail.com");

            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("Password123");

            IWebElement ConfirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            ConfirmPassword.SendKeys("Password123");

            IWebElement RegisterButton = driver.FindElement(By.Id("register-button"));
            RegisterButton.Click();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
