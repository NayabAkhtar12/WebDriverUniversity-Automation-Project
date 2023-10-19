using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webdriveruniversity_AutomationProject.PageObject
{
    public class Login
    {
        IWebDriver driver;
        By Name = By.Id("text");
        By Passwrd=By.Id("password");
        By LoginBtn = By.XPath("//*[@id=\"login-button\"]");

        public void Loginpage( IWebDriver driver)
        {
            this.driver = driver;
        }
        public void TypeUserName()
        {
            driver.FindElement(Name).SendKeys("Nayab");
        }

        public void Password()
        {
            driver.FindElement(Passwrd).SendKeys("Nayab");
        }

        public void LoginButton()
        {
            driver.FindElement(LoginBtn).Click();
        }
    }
}
