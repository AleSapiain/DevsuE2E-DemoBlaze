using E2E_DemoBlaze.Actions;
using E2E_DemoBlaze.Tasks;
using E2E_DemoBlaze.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_DemoBlaze.Tests
{
    [TestFixture]
    public class DemoBlazeTest : BaseTest
    {
        [Test]
        public void LoadHome()
        {
            Assert.That(("PRODUCT STORE").Equals( GetText.TextFrom(driver, DemoBlazeUI.homePageTitle)), "Entramos a DemoBlaze", driver);
            GoTo.homePage(driver);
            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.homeMenu), "El menú principal NO es visible");
        }

        [Test]
        public void AddToCart()
        {
            GoTo.homePage(driver);
            FilterBy.phoneCategory(driver);
            Select.phoneItem(driver);
            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.priceContainer), "No hemos abierto el detalle del producto");
            Confirm.addItem(driver);
            Confirm.infoDialog(driver);
           
            GoTo.homePage(driver);
            FilterBy.monitorCategory(driver);
            Select.monitorItem(driver); 
            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.priceContainer), "No hemos abierto el detalle del producto");
            Confirm.addItem(driver);
            Confirm.infoDialog(driver);
            GoTo.cartPage(driver);
        }

        [Test]
        public void fillPurchaseForm()
        {
            GoTo.homePage(driver);
            FilterBy.phoneCategory(driver);
            Select.phoneItem(driver);
            Confirm.addItem(driver);
            Confirm.infoDialog(driver);

            GoTo.homePage(driver);
            FilterBy.monitorCategory(driver);
            Select.monitorItem(driver);
            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.priceContainer), "No hemos abierto el detalle del producto");

            Confirm.addItem(driver);
            Confirm.infoDialog(driver);
            GoTo.cartPage(driver);

            Confirm.cart(driver);
            //Add Assert

            FillForm.Set(driver, DemoBlazeUI.orderDataName, "Nombre Test");
            FillForm.Set(driver, DemoBlazeUI.orderDataCountry, "España");
            FillForm.Set(driver, DemoBlazeUI.orderDataCity, "Barcelona");
            FillForm.Set(driver, DemoBlazeUI.orderDataCard, "4242424242424242");
            FillForm.Set(driver, DemoBlazeUI.orderDataMonth, "12");
            FillForm.Set(driver, DemoBlazeUI.orderDataYear, "2023");

            Confirm.purchase(driver);
        }
    }
}
