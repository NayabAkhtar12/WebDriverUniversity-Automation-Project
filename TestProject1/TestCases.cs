using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestFixture]
    public class TestCases : Baseclass
    {

        [Test]
        public void ContactForm()
        {
            drv.Navigate().GoToUrl("http://webdriveruniversity.com/Contact-Us/contactus.html");

            IWebElement FName = drv.FindElement(By.XPath("//*[@id=\"contact_form\"]/input[1]"));
            FName.SendKeys("Nayab");
            Thread.Sleep(3000);

            IWebElement LName = drv.FindElement(By.XPath("//*[@id=\"contact_form\"]/input[2]"));
            LName.SendKeys("Akhtar");
            Thread.Sleep(2000);

            IWebElement Email = drv.FindElement(By.CssSelector("#contact_form > input:nth-child(3)"));
            Email.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(2000);

            IWebElement Comments = drv.FindElement(By.CssSelector("#contact_form > textarea"));
            Comments.SendKeys("Nice");
            Thread.Sleep(3000);

            IWebElement Submit = drv.FindElement(By.XPath("//*[@id=\"form_buttons\"]/input[2]"));
            Submit.Click();
            Thread.Sleep(3000);
        }

        [Test]
        public void Login()
        {
            String Url = "http://webdriveruniversity.com/Login-Portal/index.html";
            drv.Navigate().GoToUrl(Url);
            string X_Username = "//*[@id=\"text\"]";
            IWebElement UserName = drv.FindElement(By.XPath(X_Username));
            UserName.SendKeys("Nayab");
           // UserName.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(3000);

            string X_Pasword = "//*[@id=\"password\"]";
            IWebElement Password = drv.FindElement(By.XPath(X_Pasword));
            Password.SendKeys("Nice123f");
            Thread.Sleep(3000);

            IWebElement Login = drv.FindElement(By.XPath("//*[@id=\"login-button\"]"));
            Login.Click();
            Thread.Sleep(3000);
        }

        [Test]
        public void ButtonClick()
        {
            String Url = "http://webdriveruniversity.com/Login-Portal/index.html";
            drv.Navigate().GoToUrl(Url);
            string X_Username = "//*[@id=\"text\"]";
            IWebElement UserName = drv.FindElement(By.XPath(X_Username));
            UserName.SendKeys("Nayab");
            // UserName.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(3000);

            string X_Pasword = "//*[@id=\"password\"]";
            IWebElement Password = drv.FindElement(By.XPath(X_Pasword));
            Password.SendKeys("Nice123f");
            Thread.Sleep(3000);

            IWebElement Login = drv.FindElement(By.XPath("//*[@id=\"login-button\"]"));
            Login.Click();
            Thread.Sleep(3000);
        }

        [Test]
        public void Buttons()
        {
            String Url = "http://webdriveruniversity.com/Login-Portal/index.html";
            drv.Navigate().GoToUrl(Url);
            string X_Username = "//*[@id=\"text\"]";
            IWebElement UserName = drv.FindElement(By.XPath(X_Username));
            UserName.SendKeys("Nayab");
            // UserName.SendKeys("nayabf52@gmail.com");
            Thread.Sleep(3000);

            string X_Pasword = "//*[@id=\"password\"]";
            IWebElement Password = drv.FindElement(By.XPath(X_Pasword));
            Password.SendKeys("Nice123f");
            Thread.Sleep(3000);

            IWebElement Login = drv.FindElement(By.XPath("//*[@id=\"login-button\"]"));
            Login.Click();
            Thread.Sleep(3000);
        }
    }
}