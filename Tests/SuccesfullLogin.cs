using SauceDemo.Test.POMs;
using Xunit;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace SauceDemo.Test.Tests
{
    public class SuccesfullLogin : BaseTest
    {
        private readonly HomePage homePage;

        public SuccesfullLogin()
        {
            homePage = new HomePage(driver);
        }

        [Theory]
        [InlineData("standard_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("locked_out_user!", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("problem_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("performance_glitch_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("error_user", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("visual_user", "secret_sauce", "https://www.saucedemo.com/")]
        public void LoginWithAcceptedUsernamesAndPassword(string username, string password, string url)
        {
            Navigate(url);
            homePage.Login(username, password);
            Assert.True(homePage.CartIconDisplayed());
        }
    }
}