
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using practicetesting.Pages;

namespace practicetesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.google.com");
        //    driver.Manage().Window.Maximize();
        //    IWebElement webelement = driver.FindElement(By.Name("q"));
        //    webelement.SendKeys("Solo leveling");
        //    webelement.SendKeys(Keys.Return);

        //    webelement.Click();
        //}
        //[Test]
        //public void eaappwebtest()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://eaapp.somee.com");
        //    //IWebElement loginlink = driver.FindElement(By.LinkText("Login"));
        //    //IWebElement loginlink = driver.FindElement(By.Id("loginLink"));
        //    //loginlink.Click();
        //    //reduce the code
        //    driver.FindElement(By.Id("loginLink")).Click();

        //    //IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
        //    //txtUserName.SendKeys("admin");
        //    driver.FindElement(By.Name("UserName")).SendKeys("admin");
        //    IWebElement password = driver.FindElement(By.Id("Password"));
        //    password.SendKeys("password");
        //    //IWebElement login = driver.FindElement(By.ClassName(".btn")); error no need .
        //    //IWebElement login = driver.FindElement(By.ClassName("btn"));
        //    IWebElement login = driver.FindElement(By.CssSelector(".btn"));
        //    login.Submit();


        //}


        //[Test]
        //public void mutipleselction()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("file:///C:/Users/sneha/OneDrive/Desktop/sele.html");
        //SelectElement selectele = new SelectElement(driver.FindElement(By.Id("dropdown")));
        //selectele.SelectByText("3");
        //Cuustommethods.selectdropdown(driver, By.Id("dropdown"), "3");

        //SelectElement multi = new SelectElement(driver.FindElement(By.Id("multiselect")));
        //multi.SelectByValue("multi1");
        //multi.SelectByValue("multi2");
        //IList<IWebElement> selectedoption = multi.AllSelectedOptions;
        //foreach (IWebElement option in selectedoption)
        //{
        //    Console.WriteLine(option.Text);
        //}

        //Cuustommethods.multiselect(driver, By.Id("multiselect"), ["multi1", "multi2"]);
        //var getallselectedoptions = Cuustommethods.getallselectedlist(driver, By.Id("multiselect"));
        //foreach(var option in getallselectedoptions)
        //{
        //   Console.WriteLine(option);
        //}
        //getallselectedoptions.ForEach(Console.WriteLine);
        //IWebElement rad = driver.FindElement(By.Id("male"));
        //rad.Click();
        //IWebElement c1 = driver.FindElement(By.Id("c1"));
        //IWebElement c2 = driver.FindElement(By.Id("c2"));
        //IWebElement c3 = driver.FindElement(By.Id("c3"));
        //if (!c1.Selected)
        //{
        //    c1.Click();
        //}

        //if (c2.Selected)
        //    {
        //        c2.Click();
        //    }
        //    c3.Click();
        //    IWebElement login = driver.FindElement(By.CssSelector("input[type='submit']"));
        //    login.Click();
        //    System.Threading.Thread.Sleep(2000);
        //    driver.Quit();
        //}

        //[Test]
        //public void CustomMethodsSel()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://eaapp.somee.com");

        //    Cuustommethods.Click(driver, By.Id("loginLink"));
        //    Cuustommethods.sendkeys(driver, By.Id("UserName"), "admin");
        //    Cuustommethods.sendkeys(driver, By.Id("Password"), "password");
        //    Cuustommethods.sunmit(driver, By.CssSelector(".btn"));

        //}

        [Test]
        public void TestwPOM()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //pom initialization
            POM loginpage = new POM(driver);
            loginpage.Clicklogin();
            loginpage.login("admin", "password");

        }
    }
}