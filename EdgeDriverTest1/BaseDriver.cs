
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace EdgeDriverTest1
{
    static class BaseDriver
    {

        private static IWebDriver Driver;
        private static IWebElement Element;

        public static IWebDriver driver
        {
            get { return Driver; }
            set { Driver = value; }
        }

        public static IWebElement element
        {
            get { return Element; }
            set { Element = value; }
        }
    }
}
