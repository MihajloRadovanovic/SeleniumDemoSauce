using OpenQA.Selenium;
namespace SauceDemo.Test.POMs
{
    public class InventoryPage
    {
        private IWebDriver driver { get; }
       
        public IWebElement ShoppingCart => driver.FindElement(By.ClassName("shopping_cart_badge"));

        public IWebElement AddtoCart => driver.FindElement(By.XPath("//button[normalize-space()='Add to cart']"));

        public IWebElement RemoveItem => driver.FindElement(By.CssSelector(".btn"));

        public InventoryPage(IWebDriver _driver)
        {
            driver = _driver;
        }

       
        public bool ShoppingCartDisplayed => ShoppingCart.Displayed;

        public void AddingOneProduct()
        {
            AddtoCart.Click();
        }
        public void AddingMoreProducts()
        {
            for (int i = 0; i < 3; i++)
            {
                AddtoCart.Click();
            }
        }
        public void RemovingAllItemsFromCart()
        {
            while (!ShoppingCart.Text.Equals(""))
            {
                RemoveItem.Click();
            }
        }
    }
}