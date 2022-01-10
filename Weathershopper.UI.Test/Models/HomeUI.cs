using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Weathershopper.UI.Test.Page;

namespace Weathershopper.UI.Test.Models
{
    public class HomeUI
    {
        #region Fields
        /// <summary>
        /// Page with repository of objects
        /// </summary>
        private HomePage page;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver">Driver to interact with the  Browser</param>
        public HomeUI(WebDriver driver) 
        {
            this.page = new HomePage(driver);
        }

        #endregion
        #region methods
        /// <summary>
        /// Click on Buy Moisturizers Button
        /// </summary>
        public void ClickOnBuyMoisturizers() 
        {
            page.buyMoisturizerButton.Click();

        }
        /// <summary>
        /// Click on Buy  Sunscreens
        /// </summary>
        public void ClickOnBuySunscreens()
        {
            page.buySunscreensButton.Click();
        }

        /// <summary>
        /// Navigate  to the page
        /// </summary>

        public void Navigate()
        {
            page.Navigate();
            
        }
        #endregion
    }
}
