using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithCSharp
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Opened browser!");

        }

        [Test]
        public void run()
        {
            IWebElement element = driver.FindElement(By.XPath("//input[@title='Ara']"));
            element.SendKeys("openAI");
            element.Submit();

            Console.WriteLine("executed the test");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();

            Console.WriteLine("And closed down");
        }
    }
}