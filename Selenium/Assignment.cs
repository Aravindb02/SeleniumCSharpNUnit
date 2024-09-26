using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nunittest.Utilities;
using OpenQA.Selenium;
namespace NUnitSelenium.AssignmetBooking
{
    internal class BookingWebSite : Base
    {
        [TestCase("mumbai")]
        [Test]
        public void testcaseBooking(string location)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?label=msn-HiTydpHndf_KligNqm9Sgw-79852220055838%3Atikwd-79852393960302%3Aloc-90%3Aneo%3Amte%3Alp116072%3Adec%3AqsBooking.com%29&aid=2369661&sid=d610a34830d9af64372a456808fcfc65");
            Thread.Sleep(1000);
            try
            {
                IWebElement closePopUpButton = driver.FindElement(By.XPath("//button[@aria-label='Dismiss sign-in info.']"));
                closePopUpButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The Pop Up window did not appear this time");
            }
            Thread.Sleep(1000);
            IWebElement locationSelector = driver.FindElement(By.Name("ss"));
            Thread.Sleep(1000); 
            locationSelector.SendKeys(location);
            Thread.Sleep(2000);
            IWebElement firstOptionResult = driver.FindElement(By.XPath("//li[@id='autocomplete-result-0']"));
            firstOptionResult.Click();
            Thread.Sleep(2000);

            IWebElement dateSelector = driver.FindElement(By.XPath("//span[contains(text(),'Check-in Date')]"));
            dateSelector.Click();
            Thread.Sleep(2000);

            IWebElement WHen = driver.FindElement(By.XPath("//*[@id=\"indexsearch\"]/div[2]/div/form/div[1]/div[2]/div/div/span[1]"));
            WHen.Click();
            Thread.Sleep(1000);
            IWebElement From = driver.FindElement(By.XPath("//span[@aria-label='21 September 2024']"));
            From.Click();


            Thread.Sleep(5000);



        }
    }
}

