using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace hockeyTest
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
           driver = new ChromeDriver(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"webdriver\"));
           driver.Manage().Window.Maximize();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Quit();
        }
    }
}
