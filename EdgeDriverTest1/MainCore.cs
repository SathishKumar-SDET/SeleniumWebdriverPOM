using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EdgeDriverTest1
{
    [TestClass]
    public class MainCore
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            BaseDriver.driver = new FirefoxDriver();
            
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            BaseDriver.driver.Dispose();
            BaseDriver.driver.Quit();
        }
    }
}
