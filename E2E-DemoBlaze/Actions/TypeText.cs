using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Actions
{
    class TypeText
    {
        public static void Set(IWebDriver driver, By locator, string critery)
        {
            driver.FindElement(locator).SendKeys(critery);
        }

        public static void Clean(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Clear();
        }
    }
}
