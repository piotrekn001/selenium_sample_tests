using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace seleniumTest
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public void beforeTests()
        {
            private static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"webdriver\");
            public static IWebDriver driver = new ChromeDriver(path);   
        }
    }
}
