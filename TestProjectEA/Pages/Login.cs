using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectEA.Pages
{
     class Login:DriverHelper
    {
        IWebElement username => Driver.FindElement(By.XPath("//input[@id='UserName']"));
        IWebElement password => Driver.FindElement(By.XPath("//input[@id='Password']"));

        IWebElement loginbtn => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void EnterUsername() => username.SendKeys("farukyucel");
        public void EnterPassword() => password.SendKeys("Fy12068036;");

        public void ClickLoginBtn() =>loginbtn.Click();




    }
}
