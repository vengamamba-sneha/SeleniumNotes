using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace practicetesting.Pages
{
   public class POM
    {
        private readonly IWebDriver driver;
        public POM(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement loginlink => driver.FindElement(By.Id("loginLink"));
        IWebElement textusername => driver.FindElement(By.Id("UserName"));
        IWebElement textpassword => driver.FindElement(By.Id("Password"));
        IWebElement btnlogin => driver.FindElement(By.CssSelector(".btn"));

        //public void Clicklogin()
        //{
        //    loginlink.Click();
        //}
        //public void login(string username,string password)
        //{
        //    textusername.SendKeys(username);
        //    textpassword.SendKeys(password);
        //    btnlogin.Submit();
        //}

        public void Clicklogin()
        {
            Cuustommethods.Click(loginlink);
        }
        public void login(string username,string password)
        {
            Cuustommethods.sendkeys(textusername, username);
            Cuustommethods.sendkeys(textpassword, password);
            Cuustommethods.Submit(btnlogin);
        }
    }
}
