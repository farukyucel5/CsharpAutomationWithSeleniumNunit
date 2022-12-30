using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace TestProjectEA.Pages
{
       class HomePage:DriverHelper
    {
        /* 
          public HomePage(IWebDriver webDriver) {
             Driver = webDriver;
         }

         private IWebDriver Driver { get; }
         
       */



        IWebElement lnkLogin => Driver.FindElement(By.Id("loginLink"));
        IWebElement lnkLogoff=>Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin()=>lnkLogin.Click();

        public bool IslogOffExist() => lnkLogoff.Displayed;








    }
}

