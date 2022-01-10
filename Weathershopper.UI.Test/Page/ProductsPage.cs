using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weathershopper.UI.Test.Page
{
    public class ProductsPage
    {
        /// <summary>
        /// Xpaths to Page elements
        /// </summary>
        #region Constants
        private const string productsXpath = "//*[@class ='btn btn-primary']";
        private const string cartButtonXpath = "//*[contains(@onclick,'goToCart')]";
       
        #endregion

        /// <summary>
        /// WebDriver
        /// </summary>
        #region Properties
        public WebDriver driver { get; set; }

        /// <summary>
        /// Cart Button
        /// </summary>
        public IWebElement cartButton
        {
            get { return driver.FindElement(By.XPath(cartButtonXpath)); }
        }

        /// <summary>
        /// Products on the page
        /// </summary>
       public  List<IWebElement> products
        {
            get
            { return driver.FindElements(By.XPath(productsXpath)).ToList(); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver">}Wbedriver to interact with the browser</param>
        public ProductsPage(WebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region methods
        /// <summary>
        /// Return List of  products filter by characteristic
        /// </summary>
        /// <param name="characteristic">Filer on onclick attribute</param>
        /// <returns></returns>
        public List<IWebElement> productsByCharacteristic(string characteristic) 
        {
            return driver.FindElements(By.XPath($"{productsXpath}[contains(@onclick,'{characteristic}')or contains(@onclick,'{characteristic.ToLower()}')]")).ToList();
        }
    }
        #endregion

    

}
