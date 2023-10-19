using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdriveruniversity_AutomationProject.PageObject;

namespace Webdriveruniversity_AutomationProject
{
    [TestFixture]
    //[OneTimeSetUp]
    public class WULogin
    {
        [Test]
        public void VerifyLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://webdriveruniversity.com/Login-Portal/index.html");
            driver.Manage().Window.Maximize();
            Login Login = new Login();
            Login.TypeUserName();
            Login.Password();
            Login.LoginButton();
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
