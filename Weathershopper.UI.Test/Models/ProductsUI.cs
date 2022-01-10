using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weathershopper.UI.Test.Page;

namespace Weathershopper.UI.Test.Models
{
    public class ProductsUI
    {
        #region Fields
        /// <summary>
        /// Page with repository of objects
        /// </summary>
        private ProductsPage page;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="driver"></param>
        public ProductsUI(WebDriver driver)
        {
            this.page = new ProductsPage(driver);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Find and Clik on Least Expensive Product based on Characteristic
        /// </summary>
        /// <param name="characteristic"></param>
        public void CllickLeastExpensiveProductByCharacteristic(string characteristic)
        {
            var products = page.productsByCharacteristic(characteristic);

            var x = products.OrderBy(x => x.GetAttribute("onclick").Split(',')[1].Trim(')')).First();

            x.Click();

        }

        /// <summary>
        /// Click on Cart Button
        /// </summary>

        public void ClickCartButton()
        {
            page.cartButton.Click();
        }
        #endregion

    }
}
