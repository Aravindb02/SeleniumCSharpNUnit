using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Clients;

namespace nunittest.Selenium
{
    internal class Alerts
    {
        private IWebDriver driver;
        public void StartBrowser() { 

        IWebElement SimpleAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
        SimpleAlert.Click();
 
    // simple alert
 
    // switch the control to alert or the pop up
 
    IAlert alt = driver.SwitchTo().Alert();

        // click on OK button

        alt.Accept();
 
    Thread.Sleep(3000);
 
    // confirmnational alert
 
    IWebElement ConfAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]"));
        ConfAlert.Click();
 
    alt.Dismiss();
 
    Thread.Sleep(3000);
 
    // prompt alerts
 
    IWebElement PromptAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));
        PromptAlert.Click();
 
    string alerttext = alt.Text;
        Console.WriteLine(alerttext);
 
    alt.SendKeys("Hello");
    Thread.Sleep(2000);
    alt.Accept();
}

    [TearDown]
    public void tearDownbrowser()
    {

        driver.Close();

    }

}
}
