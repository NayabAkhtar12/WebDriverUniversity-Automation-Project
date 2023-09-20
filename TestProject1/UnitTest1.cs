using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
       public IWebDriver drv;

        [OneTimeSetUp]
        public void Setup()
        {
           drv = new ChromeDriver();
            drv.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
            drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");
            Thread.Sleep(2000);
        }

        [Test]
        public void ContactForm()
        {
            //drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");

            IWebElement FName = drv.FindElement(By.XPath("//*[@id=\"contact_form\"]/input[1]"));
            FName.SendKeys("Nayab");
           Thread.Sleep(3000);

            IWebElement LName = drv.FindElement(By.XPath("//*[@id=\"contact_form\"]/input[2]"));
            LName.SendKeys("Akhtar");
            Thread.Sleep(2000);

            IWebElement Email = drv.FindElement(By.CssSelector("#contact_form > input:nth-child(3)"));
            Email.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(2000);

            IWebElement Comments = drv.FindElement(By.ClassName("\"feedback-input\""));
            Comments.SendKeys("Nice");
            Thread.Sleep(2000);

            IWebElement Submit = drv.FindElement(By.ClassName("contact_button"));
            Submit.Click();
            Thread.Sleep(3000);
        }

        //[Test]
        //public void checkbox()
        //{
        //    driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

        //    IWebElement checkbox = driver.FindElement(By.CssSelector("#tree-node > ol > li > span > label > span.rct-checkbox > svg"));
        //    checkbox.Click();
        //    Thread.Sleep(3000);
        //}

        [OneTimeTearDown]
       public void close()
        {
            drv.Quit();
            drv.Dispose();
            Thread.Sleep(3000);
        }
    }
}