using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProjectEA.Pages;

namespace TestProjectEA
{
    public class Tests:DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("Setup");
        }

        [Test]
        public void LoginTest1()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage home=new HomePage();
            Login login=new Login();

            home.ClickLogin();
            login.EnterUsername();
            login.EnterPassword();
            login.ClickLoginBtn();

            Assert.That(home.IslogOffExist(),Is.True,"log off is not visible");


        }

        [TearDown] public void TearDown()
        {
            Thread.Sleep(3000);
            Driver.Quit();
        }
    }
}