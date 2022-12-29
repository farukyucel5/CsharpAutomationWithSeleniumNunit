using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMethods
{
    internal class SeleniumSetMethods
    {
        //Enter text

        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "XPath")
                driver.FindElement(By.XPath(element)).SendKeys(value);




        }

        //click into a button ,checkbox,option;

        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();

            if (elementType == "XPath")
                driver.FindElement(By.XPath(element)).Click();



        }

        //select drop down

        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {

            if (elementType == "Id")
            {
                SelectElement selectelement = new SelectElement(driver.FindElement(By.Id(element)));

                selectelement.SelectByText(value);
            }
            if (elementType == "Name")
            {
                SelectElement selectelement = new SelectElement(driver.FindElement(By.Name(element)));

                selectelement.SelectByText(value);
            }

            if (elementType == "XPath")
            {
                SelectElement selectelement = new SelectElement(driver.FindElement(By.XPath(element)));

                selectelement.SelectByText(value);
            }







        }
    }
}
