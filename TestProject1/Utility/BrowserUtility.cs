using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webdriveruniversity_AutomationProject.Utility
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Url = "http://webdriveruniversity.com/Contact-Us/contactus.html";
            driver.Manage().Window.Maximize();

            return driver;
        }

    }
}
