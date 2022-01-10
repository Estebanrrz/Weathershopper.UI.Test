using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Weathershopper.UI.Test.Models;
using Weathershopper.UI.Test.Page;

namespace Weathershopper.UI.Test
{
    [TestClass]
    public class HomePageTest
    {
        private HomeUI homeUI;
        private WebDriver driver;

        #region Test methods
        /// <summary>
        /// Initialize the tests
        /// </summary>
        [TestInitialize]
        public virtual void TestInit()
        {
            //Select the browser to use
            string browser = "Chrome";
            //string browser = "Firefox";

            if (browser.Equals("Chrome"))
            {
                driver = new ChromeDriver();

            } else if (browser.Equals("Firefox")) 
            {
                driver = new FirefoxDriver();
            }
            homeUI = new HomeUI(driver);
        }

        [TestMethod]
        public void BuyMoisteturizers()
        {
            homeUI.Navigate();
            homeUI.ClickOnBuyMoisturizers();
            ProductsUI productUI = new ProductsUI(driver);
            productUI.CllickLeastExpensiveProductByCharacteristic("Aloe");
            productUI.CllickLeastExpensiveProductByCharacteristic("Almond");
            productUI.ClickCartButton();
        }

        [TestMethod]
        public void BuySunscreens()
        {
            homeUI.Navigate();
            homeUI.ClickOnBuySunscreens();
            ProductsUI productUI = new ProductsUI(driver);
            productUI.CllickLeastExpensiveProductByCharacteristic("SPF-50");
            productUI.CllickLeastExpensiveProductByCharacteristic("SPF-30");
            productUI.ClickCartButton();
        }

        /// <summary>
        /// CleanUp the tests
        /// </summary>
        [TestCleanup]
        public virtual void TestCleanUp()
        {
            driver.Close();
        }
        #endregion
    }
}
