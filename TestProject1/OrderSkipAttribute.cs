using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(2),Category("skipattribute")]
        public void ContactFormEmail()
        {
            Assert.Ignore("SomeReason");
            IWebDriver drv=new ChromeDriver();

            drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");
            drv.Manage().Window.Maximize();
            IWebElement Email = drv.FindElement(By.CssSelector("#contact_form > input:nth-child(3)"));
            Email.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(2000);
            drv.Close();
        }

        [Test, Order(1), Category("skipattribute")]
        public void ContactForName()
        {
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");
            drv.Manage().Window.Maximize();
            IWebElement FName = drv.FindElement(By.XPath("//*[@id=\"contact_form\"]/input[1]"));
            FName.SendKeys("Nayab");
            Thread.Sleep(3000);
            drv.Close();
        }
        [Test, Order(0), Category("skipattribute")]
        public void ContactFormComments()
        {
            IWebDriver drv = new ChromeDriver();

            drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");
            drv.Manage().Window.Maximize();
            IWebElement Comments = drv.FindElement(By.CssSelector("#contact_form > textarea"));
            Comments.SendKeys("Nice");
            Thread.Sleep(3000);
            drv.Close();
        }
        //[Test]
        //public void checkbox()
        //{
        //    driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

        //    IWebElement checkbox = driver.FindElement(By.CssSelector("#tree-node > ol > li > span > label > span.rct-checkbox > svg"));
        //    checkbox.Click();
        //    Thread.Sleep(3000);
        //}


    }
}