using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nunittest.Utilities;
using OfficeOpenXml.Style;
using OpenQA.Selenium;

namespace nunittest.DataDrivenTesting
{
    
    internal class TestParamExcel:Base
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + " " + password);
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

            //IWebElement err = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            //string error = err.Text;

            //Console.WriteLine(error);
            //Assert.AreEqual("Invalid credentials", error);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\arach\\source\\repos\\nunittest\\testdata.xlsx","LoginTest",columns);
        }
        }
}
