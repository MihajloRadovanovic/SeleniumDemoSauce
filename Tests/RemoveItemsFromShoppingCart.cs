using SauceDemo.Test.POMs;
using Xunit;
using System;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;


namespace SauceDemo.Test.Tests
{
    public class RemoveItemsFromShoppingCart : BaseTest
    {
        [Theory]
        [InlineData("standard_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("locked_out_user!", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("problem_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("performance_glitch_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("error_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("visual_user", "secret_sauce", "https://www.saucedemo.com/")]
        public void RemoveItemsFromTheCart(string username, string password, string url)
        {
            var homePage = new HomePage(driver);
            var inventoryPage = new InventoryPage(driver);

            Navigate(url);
            homePage.Login(username, password);
            inventoryPage.AddingMoreProducts();
            homePage.RemovingAllItems();

            Assert.True(string.IsNullOrEmpty(homePage.ShoppingCart.Text));
        }

        [Theory]
        [InlineData("standard_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("locked_out_user!", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("problem_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("performance_glitch_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("error_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("visual_user", "secret_sauce", "https://www.saucedemo.com/")]
        public void RemoveItemFromTheCart(string username, string password, string url)
        {
            var homePage = new HomePage(driver);
            var inventoryPage = new InventoryPage(driver);

            Navigate(url);
            homePage.Login(username, password);
            inventoryPage.AddingOneProduct();
            homePage.RemovingAllItems();

            Assert.True(string.IsNullOrEmpty(homePage.ShoppingCart.Text));
        }
    }
}
