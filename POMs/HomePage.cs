using OpenQA.Selenium;
namespace SauceDemo.Test.POMs
{
    public class HomePage
    {
        private IWebDriver driver { get; }
        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement ButtonLogin => driver.FindElement(By.Id("login-button"));
        public IWebElement SauceDemo => driver.FindElement(By.ClassName("peek"));

        public IWebElement CartIcon => driver.FindElement(By.ClassName("shopping_cart_link"));

        public IWebElement RemoveItem => driver.FindElement(By.XPath("//button[text()='Remove']"));

        public IWebElement ShoppingCart => driver.FindElement(By.ClassName("shopping_cart_link"));
        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public bool DisplayedUserNameField() => UserName.Displayed;

        public bool DisplayedPasswordField() => Password.Displayed;

        public bool DisplayedLoginButton() => ButtonLogin.Displayed;

        public bool SauceDemoLogoDisplayed() => SauceDemo.Displayed;

        public bool CartIconDisplayed() => CartIcon.Displayed;

        public void UserNameField() => UserName.Click();

        public void Login(string username_input, string password_input)
        {
            UserName.SendKeys(username_input);
            Password.SendKeys(password_input);
            ButtonLogin.Click();
        } 
        public void RemovingAllItems()
        {
            while (!ShoppingCart.Text.Equals(""))
            {
                RemoveItem.Click();
            }
        }
    }
}