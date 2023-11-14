using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Baseclass
    {
        public IWebDriver drv;

        [OneTimeSetUp]
        public void Setup()
        {
            drv = new ChromeDriver();
            drv.Navigate().GoToUrl("http://webdriveruniversity.com");
            drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            drv.Manage().Window.Maximize();
          //  Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void close()
        {
            drv.Quit();
            drv.Dispose();
            Thread.Sleep(3000);
        }
    }
}
