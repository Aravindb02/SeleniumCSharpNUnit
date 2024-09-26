using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using nunittest.Utilities;

namespace nunittest.Selenium
{
    internal class Scrolling:Base
    {
       
        [Test]
        public void Run()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)", "");
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,-300)", "");
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollTo(0,document.body.scollHeight)");
            Thread.Sleep(2000);
            //Take Screensot class and getscreenshotAs method
        }
    }
}
