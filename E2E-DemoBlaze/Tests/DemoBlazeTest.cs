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
        public void fillPurchaseForm()
        {
            GoTo.homePage(driver);
            FilterBy.phoneCategory(driver);
            Select.phoneItem(driver);

            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.addToCartButton), "No hemos abierto el detalle del producto");

            Confirm.addItem(driver);
            Confirm.infoDialog(driver);

            GoTo.homePage(driver);
            FilterBy.monitorCategory(driver);
            Select.monitorItem(driver);
            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.addToCartButton), "No hemos abierto el detalle del producto");

            Confirm.addItem(driver);
            Confirm.infoDialog(driver);
            GoTo.cartPage(driver);

            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.cartList), "No hemos encontrado el detalle del carrito de compras");
            Confirm.cart(driver);
            Assert.IsTrue(IsDisplayed.element(driver, DemoBlazeUI.orderDataModal), "No se abrio el formulario de confirmación de compra");
            Assert.That(("Place order").Equals(GetText.TextFrom(driver, DemoBlazeUI.orderDataModal)), "No se abrio el formulario de confirmación de compra.", driver);

            Confirm.purchase(driver);
            Confirm.infoDialog(driver);

            FillForm.Set(driver, DemoBlazeUI.orderDataName, "Nombre Test");
            FillForm.Set(driver, DemoBlazeUI.orderDataCountry, "España");
            FillForm.Set(driver, DemoBlazeUI.orderDataCity, "Barcelona");
            FillForm.Set(driver, DemoBlazeUI.orderDataCard, "4242424242424242");
            FillForm.Set(driver, DemoBlazeUI.orderDataMonth, "12");
            FillForm.Set(driver, DemoBlazeUI.orderDataYear, "2023");

            Confirm.purchase(driver);
            Assert.That(("Thank you for your purchase!").Equals(GetText.TextFrom(driver, DemoBlazeUI.confirmPurchaseModal)), "No se completó la compra.", driver);
        }
    }
}
