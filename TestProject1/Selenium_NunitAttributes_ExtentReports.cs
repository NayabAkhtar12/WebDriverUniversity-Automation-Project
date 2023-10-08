using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace TestProject1
{
    [TestFixture]
    public class Selenium_NunitAttributes_ExtentReports
    {
        ExtentReports extent = null;

        //Extent Report Feature
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent=new ExtentReports();
            var htmlReporter = new ExtentSparkReporter(@"D:\Automation Testing\WebDriverUniversity-Automation-Project\WebDriverUniversity-AutomationProject\WebDriverUniversity-Automation-Project\TestProject1\ExtentReports\EReport1.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();
        }

        [Test]
        public void ContactFormComments1()
        {
            ExtentTest Test=null;
            IWebDriver driver1 = null;
            try
            {
                Test = extent.CreateTest("Test").Info("Test started");
                driver1 = new ChromeDriver();

                // drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");

                driver1.Url = "http://webdriveruniversity.com/Contact-Us/contactus.html";
                driver1.Manage().Window.Maximize();
                Test.Log(Status.Info,"Chrome Browser Launched");  
                IWebElement Comments = driver1.FindElement(By.CssSelector("#contact_form > textarea"));
                Comments.SendKeys("Nice");
                Thread.Sleep(3000);
                Test.Log(Status.Info, "Comment Entered");
                driver1.Quit();
                Test.Log(Status.Pass, "Passed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver1 != null)
                {
                    driver1.Quit();
                }
            }
        }

        [Test]
        public void ContactFormComments2()
        {
            ExtentTest Test = null;
            IWebDriver driver1 = null;
            try
            {
                Test = extent.CreateTest("Test").Info("Test started");
                driver1 = new ChromeDriver();

                // drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");

                driver1.Url = "http://webdriveruniversity.com/Contact-Us/contactus.html";
                driver1.Manage().Window.Maximize();
                Test.Log(Status.Info, "Chrome Browser Launched");
                IWebElement Comments = driver1.FindElement(By.CssSelector("#contact_form > textare"));
                Comments.SendKeys("Nice");
                Thread.Sleep(3000);
                Test.Log(Status.Info, "Comment Entered");
                driver1.Quit();
                Test.Log(Status.Pass, "Passed");
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail,e.ToString());
                throw;
            }
            finally
            {
                if (driver1 != null)
                {
                    driver1.Quit();
                }
            }
        }
    }
}