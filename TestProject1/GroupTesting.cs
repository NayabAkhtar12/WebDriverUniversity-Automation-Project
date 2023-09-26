using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel;
using Webdriveruniversity_AutomationProject.Utility;

namespace TestProject1
{
    [TestFixture]
    public class GroupTesting
    {
        IWebDriver driver;

        [Test, NUnit.Framework.Category("UAT Testing"), NUnit.Framework.Category("m1"), Author ("Nayab")]
        public void ContactForm()
        {
            var Driver=new BrowserUtility().Init(driver);
            IWebElement Email = Driver.FindElement(By.CssSelector("#contact_form > input:nth-child(3)"));
            Email.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(2000);

            Driver.Close();
            //IWebElement Submit = driver.FindElement(By.XPath("//*[@id=\"form_buttons\"]/input[2]"));
            //Submit.Click();
            //Thread.Sleep(3000);
        }



      
    }
}