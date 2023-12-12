using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Actions
{
    class IsDisplayed
    {
        public static bool element(IWebDriver driver, By locator)
        {
            Thread.Sleep(2000); 
            return driver.FindElement(locator).Displayed;
        }
    }
}
