using SauceDemo.Test.POMs;
using Xunit;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace SauceDemo.Test.Tests
{
    public class AddingItemsToShoppingBasket : BaseTest
    {
        private readonly HomePage homePage;
        private readonly InventoryPage inventoryPage;
        SuccesfullLogin succesfullLogin;

        public AddingItemsToShoppingBasket()
        {
            inventoryPage = new InventoryPage(driver);
            homePage = new HomePage(driver);
        }

   
        [Theory]
        [InlineData("standard_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("locked_out_user!", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("problem_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("performance_glitch_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("error_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("visual_user", "secret_sauce", "https://www.saucedemo.com/")]
        public void ShouldBeThreeItemsInCart(string username, string password, string url)
        {
            Navigate(url);
            homePage.Login(username, password);           
            inventoryPage.AddingMoreProducts();          
            Assert.Equal(homePage.ShoppingCart.Text, "3");     
        }
        
        [Theory]
        [InlineData("standard_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("locked_out_user!", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("problem_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("performance_glitch_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("error_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("visual_user", "secret_sauce", "https://www.saucedemo.com/")]
        public void ShouldBeOneItemInCart(string username, string password, string url)
        {
            Navigate(url);
            homePage.Login(username, password);        
            inventoryPage.AddingOneProduct();
            Assert.Equal(homePage.ShoppingCart.Text, "1");
        }
    }
}