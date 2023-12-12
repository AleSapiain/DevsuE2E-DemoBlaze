using E2E_DemoBlaze.Actions;
using E2E_DemoBlaze.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Tasks
{
    class GoTo
    {
        public static void homePage(IWebDriver driver)
        {
            
            Click.On(driver, DemoBlazeUI.homeMenu);
        }

        public static void cartPage(IWebDriver driver)
        {
            Click.On(driver, DemoBlazeUI.cartMenu);
        }
    }
}
