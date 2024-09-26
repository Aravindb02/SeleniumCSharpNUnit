using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nunittest.Utilities;
using OpenQA.Selenium;

namespace NUnitSelenium.TestDrivenTesting
{
    class TestParForLogin : Base
    {
        //[TestCase("Admin", "admin123")]
        [TestCase("xyz.com", "gfyhjbn")]
        [TestCase("dhj.com", "gvhb")]
        public void testCaseLogin(string username, string password)
        {

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();
            Thread.Sleep(2000);

            IWebElement err = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            string  error = err.Text;

            Console.WriteLine(error);
            Assert.AreEqual("Invalid credentials", error);
            


        }
    }
}