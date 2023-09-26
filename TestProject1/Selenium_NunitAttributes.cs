using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace TestProject1
{
    [TestFixture]
    public class Selenium_NunitAttributes
    {
        [Test,Order(2),Category("skipattribute")]
        public void ContactFormEmail()
        {
            NUnit.Framework.Assert.Ignore("SomeReason");
            IWebDriver drv=new ChromeDriver();

            drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");
            drv.Manage().Window.Maximize();
            IWebElement Email = drv.FindElement(By.CssSelector("#contact_form > input:nth-child(3)"));
            Email.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(2000);
            drv.Close();
        }

        //Order and Skip Attribute
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
     
        //Try Catch Finally Block 
        //TestCase Source Attribute

        [Test,TestCaseSource("DataDrivenTesting")]
        public void ContactFormComments(string URL)
        {
            IWebDriver driver1 = null;
            try{
                driver1 = new ChromeDriver();

                // drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");

                driver1.Url = URL;
                driver1.Manage().Window.Maximize();
                IWebElement Comments = driver1.FindElement(By.CssSelector("#contact_form > textarea"));
                Comments.SendKeys("Nice");
                Thread.Sleep(3000);
                driver1.Quit();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver1!=null)
                {
                    driver1.Quit();
                }
            }  

           
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("http://webdriveruniversity.com/Contact-Us/contactus.html");
            return list;
        }


    }
}