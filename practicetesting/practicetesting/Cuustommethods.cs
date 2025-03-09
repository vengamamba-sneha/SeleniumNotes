using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace practicetesting
{
   public class Cuustommethods
    {
        public static void Click(IWebElement locator)
        {
            locator.Click();
        }
        public static void Submit(IWebElement locator)
        {
            locator.Submit();
        }

        public static void sendkeys(IWebElement locator, string text)
        {
            locator.Clear(); //clears the text box then performs the action
            locator.SendKeys(text);
        }

        public static void selectdropdown(IWebElement locator,string text) //val too
        {
            SelectElement select = new SelectElement(locator);
           select.SelectByText(text);

        }
       

        public static void multiselect(IWebElement locator, string[] valuws)
        {
            SelectElement select = new SelectElement(locator);
            foreach (var value in valuws)
                {
                select.SelectByValue(value);
            }
        }

        public static List<string> getallselectedlist(IWebElement locator)
        {
            List<string> options = new List<string>();
            SelectElement select = new SelectElement(locator);

            IList<IWebElement> selectedoption = select.AllSelectedOptions;
            foreach (IWebElement option in selectedoption)
            {
                options.Add(option.Text);
            }
            return options;
        }
    }
}
