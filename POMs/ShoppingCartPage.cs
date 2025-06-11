using OpenQA.Selenium;

namespace SauceDemo.Test.POMs
{
    public class ShoppingCartPage
    {
        private IWebDriver driver { get; }
        
        public IWebElement BackToShopping => driver.FindElement(By.ClassName("btn_secondary"));

        public IWebElement RemoveItem => driver.FindElement(By.CssSelector(".btn.btn_secondary.btn_small.cart_button"));

        public IWebElement ShoppingCart => driver.FindElement(By.ClassName("shopping_cart_link"));

        public ShoppingCartPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public bool IsBackToShoppingDisplayed => BackToShopping.Displayed;

        public void RemovingAllItems()
        {
            while (!ShoppingCart.Text.Equals(""))
            {
                RemoveItem.Click();
            }
        }
    }
}



