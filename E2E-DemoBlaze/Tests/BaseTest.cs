using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace E2E_DemoBlaze.Tests
{
    public class BaseTest
    {
        ChromeOptions options = new ChromeOptions();
        protected IWebDriver? driver;
        protected string Url = "https://www.demoblaze.com/";

        [SetUp]
        public void SetupBase()
        {
            try
            {
                options.AddArguments("--start-maximized");
                options.AddArguments("--incognito");

                driver = new ChromeDriver(@"..\..\..\resources", options);
                driver.Navigate().GoToUrl(Url);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TearDown]
        public void TearDownBase()
        {
            if (driver != null)
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Quit();
        }
    }
}
