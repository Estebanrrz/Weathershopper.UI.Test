using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weathershopper.UI.Test.Page
{
   public class HomePage
    {
        /// <summary>
        /// Xpaths to Page elements
        /// </summary>
        #region Constants
        private const string BuyMoisturizersXpath = "//*[@class='btn btn-primary'][text() ='Buy moisturizers']";
        private const string BuySunscreensXpath = "//*[@class='btn btn-primary'][text() ='Buy sunscreens']";
        private const string homePageUrl = "https://weathershopper.pythonanywhere.com/";

        #endregion

        #region Properties
        /// <summary>
        /// WebDriver
        /// </summary>
        public WebDriver driver { get; set; }

        /// <summary>
        /// Buy Moisturizer Button
        /// </summary>
        public IWebElement buyMoisturizerButton 
        { 
         get {
                return   driver.FindElement(By.XPath(BuyMoisturizersXpath));
            }
        }

        /// <summary>
        /// Buy Sunscreen Button
        /// </summary>
        public IWebElement buySunscreensButton
        {
            get
            {
                return driver.FindElement(By.XPath(BuySunscreensXpath));
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver">webdriver to interact with the browser</param>
        public HomePage(WebDriver driver) 
        {
            this.driver = driver;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Navigate to the  HomePage
        /// </summary>
        public void Navigate() 
        {
            driver.Manage().Window.Maximize();
            driver.Url = homePageUrl;
           
        }
        #endregion

    }
}
