using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.UI
{
    class DemoBlazeUI
    {
        public static By homePageTitle = By.XPath("/html/body/nav/a");
        public static By homeMenu = By.XPath("//div[1]/ul/li[1]/a");
        public static By cartMenu = By.XPath("/html/body/nav/div/div/ul/li[4]/a");

        public static By itemCategoryPhones = By.XPath("/html/body/div[5]/div/div[1]/div/a[2]");
        public static By itemCategoryLaptops = By.XPath("/html/body/div[5]/div/div[1]/div/a[3]");
        public static By itemCategoryMonitors = By.XPath("/html/body/div[5]/div/div[1]/div/a[4]");

        public static By itemPhoneObject = By.CssSelector("#tbodyid > div:nth-child(2) > div > a");
        public static By itemLaptopObject = By.CssSelector("#tbodyid > div:nth-child(6) > div > a");
        public static By itemMonitorObject = By.CssSelector("#tbodyid > div:nth-child(1) > div.card > a");

        public static By addToCartButton = By.XPath("/html/body/div[5]/div/div[2]/div[2]/div/a");
        public static By placeOrderbutton = By.XPath("/html/body/div[6]/div/div[2]/button");

        public static By priceContainer = By.CssSelector("#tbodyid > h3.price-container");

        public static By orderDataName = By.CssSelector("#name");
        public static By orderDataCountry = By.CssSelector("#country");
        public static By orderDataCity = By.CssSelector("#city");
        public static By orderDataCard = By.CssSelector("#card");
        public static By orderDataMonth = By.CssSelector("#month");
        public static By orderDataYear = By.CssSelector("#year");
        public static By orderDataConfirmPurchase = By.XPath("/html/body/div[3]/div/div/div[3]/button[2]");
        public static By confirmPurchaseModal = By.CssSelector("body > div.sweet-alert.showSweetAlert.visible > h2");
    }
}
