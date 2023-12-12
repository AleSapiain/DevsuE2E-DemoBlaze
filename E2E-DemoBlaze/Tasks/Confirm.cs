using E2E_DemoBlaze.Actions;
using E2E_DemoBlaze.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Tasks
{
    class Confirm
    {
        public static void addItem(IWebDriver driver)
        {
            Click.On(driver, DemoBlazeUI.addToCartButton);
        }

        public static void cart(IWebDriver driver)
        {
            Click.On(driver, DemoBlazeUI.placeOrderbutton);
        }

        public static void purchase(IWebDriver driver)
        {
            Thread.Sleep(2000);
            Click.On(driver, DemoBlazeUI.orderDataConfirmPurchase);
        }

        public static void infoDialog(IWebDriver driver)
        {
            //Press Enter to Close dialog
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           Thread.Sleep(2000); 
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(1000);
            alert.Accept();
            //driver.SwitchTo().ActiveElement().SendKeys("Intro");
        }
    }
}
