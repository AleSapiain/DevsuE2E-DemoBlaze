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
    class Select
    {
        public static void phoneItem(IWebDriver driver)
        {
            Click.On(driver, DemoBlazeUI.itemPhoneObject);
        }

        public static void laptopItem(IWebDriver driver)
        {
            Click.On(driver, DemoBlazeUI.itemLaptopObject);
        }

        public static void monitorItem(IWebDriver driver)
        {
            Click.On(driver, DemoBlazeUI.itemMonitorObject);
        }
    }
}
