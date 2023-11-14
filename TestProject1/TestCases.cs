using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            drv.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(3);


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
           // WebDriverWait Wait=

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
            String Url = "http://webdriveruniversity.com/Click-Buttons/index.html";
            drv.Navigate().GoToUrl(Url);
            string WebElement_Click= "//*[@id=\"button1\"]/p";
            IWebElement webElement1 = drv.FindElement(By.XPath(WebElement_Click));
            webElement1.Click();
            string message1= "//*[@id=\"myModalClick\"]/div/div/div[3]/button";
            IWebElement popup1 = drv.FindElement(By.XPath(message1));
            popup1.Click();
            Thread.Sleep(3000);

            string JavaScript_Click = "//*[@id=\"button2\"]";
            IWebElement webElement2 = drv.FindElement(By.XPath(JavaScript_Click));
            webElement2.Click();
            Thread.Sleep(3000);
            string message2 = "//*[@id=\"myModalJSClick\"]/div/div/div[3]/button";
            IWebElement popup2 = drv.FindElement(By.XPath(message2));
            popup2.Click();
            Thread.Sleep(3000);

            string Action_Move_Click = "//*[@id=\"button3\"]";
            IWebElement webElement3 = drv.FindElement(By.XPath(Action_Move_Click));
            webElement3.Click();
            Thread.Sleep(3000);
            string message3 = "//*[@id=\"myModalMoveClick\"]/div/div/div[3]/button";
            IWebElement popup3 = drv.FindElement(By.XPath(message3));
            popup3.Click();
            Thread.Sleep(3000);
        }

        //Test cases for Dropdown ,Checkboxes, Radio Button 
        [Test]
        public void Buttons()
        {
            String Url = "http://webdriveruniversity.com/Dropdown-Checkboxes-RadioButtons/index.html";
            drv.Navigate().GoToUrl(Url);


            string DropdownXpath = "//*[@id=\"dropdowm-menu-1\"]";
            SelectElement DropDown1 = new SelectElement(drv.FindElement(By.XPath(DropdownXpath)));
            DropDown1.SelectByText("C#");
            Thread.Sleep(3000);

            string Dropdown2Xpath = "//*[@id=\"dropdowm-menu-2\"]";
            SelectElement DropDown2 = new SelectElement(drv.FindElement(By.XPath(Dropdown2Xpath)));
            DropDown2.SelectByValue("testng");
            Thread.Sleep(3000);

            string Dropdown3Xpath = "//*[@id=\"dropdowm-menu-3\"]";
            SelectElement DropDown3 = new SelectElement(drv.FindElement(By.XPath(Dropdown3Xpath)));
            DropDown3.SelectByValue("jquery");
            Thread.Sleep(3000);

            //string CheckboxXpath = "//*[@id=\"checkboxes\"]";
            //IList<IWebElement> Checkbox = drv.FindElements(By.XPath(CheckboxXpath));
            // int CheckboxIndexToSelect = 1;
            // if(CheckboxIndexToSelect>=0 & CheckboxIndexToSelect<Checkbox.Count)
            // {
            //     Checkbox[CheckboxIndexToSelect].Click();
            // }
            // else
            // {
            //     Console.WriteLine("Invalid Checkbox");
            // }
            // Thread.Sleep(3000);

            string CheckboxXPath = "//*[@id=\"checkboxes\"]/label[1]";
            IWebElement Checkbox = drv.FindElement(By.XPath(CheckboxXPath));
            Checkbox.Click();
            Thread.Sleep(3000);

                  string CheckboxXPath3 = "//*[@id=\"checkboxes\"]/label[3]";
            IWebElement Checkbox3 = drv.FindElement(By.XPath(CheckboxXPath3));
            Checkbox3.Click();
            Thread.Sleep(3000);


            string RadioButtonPath = "//*[@id=\"radio-buttons\"]/input[5]";
            IWebElement RadioButton = drv.FindElement(By.XPath(RadioButtonPath));
            RadioButton.Click();
            Thread.Sleep(3000);
            string RadioButton2Path = "//*[@id=\"radio-buttons\"]/input[2]";
            IWebElement RadioButton2 = drv.FindElement(By.XPath(RadioButton2Path));
            RadioButton2.Click();
            Thread.Sleep(3000);

        }
    }
}