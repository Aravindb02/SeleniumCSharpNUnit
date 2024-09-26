using System;
using System.Collections.Generic;
using NUnit.Framework;
using nunittest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace nunittest.DataDrivenTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    internal class ParallelExecution : Base
    {
        [Parallelizable(ParallelScope.All)]
        [Test, TestCaseSource(nameof(GetTestData))]
        public void LoginTest(string username, string password)
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();


           

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();

            DateTime currTime = DateTime.Now;
            string time = currTime.ToString("yyyy-MM-dd-HH-mm-ss");
            Console.WriteLine(username + ":" + password + "........." + time);
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("Admin", "admin123");
            yield return new TestCaseData("xyz.com", "gfyhjbn");
            yield return new TestCaseData("dhj.com", "gvhb");
        }
    }
}
