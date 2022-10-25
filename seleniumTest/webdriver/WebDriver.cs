using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest
{
    public static class WebDriver
    {
        static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"webdriver\");

        public static IWebDriver driver = new ChromeDriver(path);
    }
}
