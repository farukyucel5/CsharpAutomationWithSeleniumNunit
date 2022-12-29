using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMethods
{
    internal class SeleniumGetMethods
    {
        public static string getText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }

            if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
