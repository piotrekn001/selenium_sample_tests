using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace hockeyTest
{
    public class Helpers
    {
        static readonly IWebDriver driver = Hooks1.driver;

        public static void OpenUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public static By ById(string id)
        {
            return By.Id(id);
        }
        public static By ByCss(string css)
        {
            return By.CssSelector(css);
        }

        public static void Click(By selector, bool clickHidden = false)
        {
            try
            {
                WaitForElement(selector);
                driver.FindElement(selector).Click();
            }
            catch
            {
                if (clickHidden)
                {
                    ClickHidden(selector);
                }
            }
        }
        public static void ClickHidden(By selector)
        {
            IWebElement element = driver.FindElement(selector);
            string script = "arguments[0].click();";

            ExecuteJavaScriptOnElement(script, element);
        }
        public static void WaitForElement(By selector, int waitTime = 3)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(ExpectedConditions.ElementExists(selector));
            wait.Until(ExpectedConditions.ElementIsVisible(selector));
        }
        public static void SwitchToIFrame()
        {
            driver.SwitchTo().Frame(0);
        }
        public static void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }
        public static void EnterText(By selector, string text, bool pressEnter = false)
        {            
            WaitForElement(selector);
            IWebElement element = driver.FindElement(selector);
            element.SendKeys(text);
            if (pressEnter)
            {
                element.SendKeys(Keys.Enter);
            }
        }
        public static bool CheckIfElementIsDisplayed(By selector)
        {
            try
            {
                WaitForElement(selector);
            }
            catch
            {

            }
            
            if (driver.FindElement(selector).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }
        public static void ExecuteJavaScriptOnElement(string script, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(script, element);
        }
        public static void ExecuteJavaScript(string script)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
        public static void OpenUrlInNewTab(string url)
        {
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            ExecuteJavaScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl(url);
        }

    }
}
