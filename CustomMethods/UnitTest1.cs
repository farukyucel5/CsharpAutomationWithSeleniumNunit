using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CustomMethods
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();

            Console.WriteLine("initialized");
        }

        [Test]
        public void Executation()
        {
            Console.WriteLine("just executed");
            //title
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=f&Password=k&Login=Login");
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            //initial
            SeleniumSetMethods.EnterText(driver, "Initial", "ISTQB", "Name");

            Console.WriteLine("The value from my title is: " + SeleniumGetMethods.getText(driver, "TitleId", "Id"));
            Console.WriteLine("The value from my initial is: " + SeleniumGetMethods.getText(driver, "Initial", "Name"));

            //click
            SeleniumSetMethods.Click(driver, "Save", "Name");



        }
        [Test]
        public void NextTest()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            Console.WriteLine("The second has started");



        }

        [Test]
        public void GalaFurniture()
        {
            // 
            driver.Navigate().GoToUrl("https://www.galafurn.com/");

            

            String searchText = "Español";
            IWebElement dropdown = driver.FindElement(By.XPath("(//*[@class='icon fill-current icon-ui-chevron-down'])[1]"));
            dropdown.Click(); // assuming you have to click the "dropdown" to open it
            IList<IWebElement> options = dropdown.FindElements(By.XPath("//li[@tabindex='-1']"));

            options[1].Click();

            var actualTitle = driver.FindElement(By.XPath("//h3[text()='Furniture Categories']"));

            Assert.That(!actualTitle.Text.Equals("Furniture Categories"), Is.False);


          
        }

        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

      
    }
}