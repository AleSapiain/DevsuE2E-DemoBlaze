using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Tasks
{
    class FillForm
    {
        public static void Set(IWebDriver driver, By locator, string critery)
        {
            driver.FindElement(locator).SendKeys(critery);
        }
    }
}
