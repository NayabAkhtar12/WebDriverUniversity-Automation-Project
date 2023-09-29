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
            drv.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
            drv.Navigate().GoToUrl("http://webdriveruniversity.com");
            drv.Manage().Window.Maximize();
            Thread.Sleep(2000);
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
