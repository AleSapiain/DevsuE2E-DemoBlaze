using Microsoft.VisualStudio.TestPlatform.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Actions
{
    class GetText
    {
        public static string TextFrom(IWebDriver driver, By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            string text =  driver.FindElement(locator).Text.ToString();
            Console.Write(text);
            return text;
        }
    }
}
