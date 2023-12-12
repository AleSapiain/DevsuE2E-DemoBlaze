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
    class FilterBy
    {
        public static void phoneCategory(IWebDriver driver)
        {
            Thread.Sleep(2000);
            Click.On(driver, DemoBlazeUI.itemCategoryPhones);
        }

        public static void laptopCategory(IWebDriver driver)
        {
            Thread.Sleep(2000);
            Click.On(driver, DemoBlazeUI.itemCategoryLaptops);
        }

        public static void monitorCategory(IWebDriver driver)
        {
            Thread.Sleep(2000);
            Click.On(driver, DemoBlazeUI.itemCategoryMonitors);
        }
    }
}
