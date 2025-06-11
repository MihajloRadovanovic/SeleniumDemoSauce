using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemo.Test
{
   
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;
        private bool disposed = false;

        public BaseTest()
        {
            var options = new ChromeOptions();
            options.AddArguments("--incognito"); // to avoid google password manager data breach
            options.AddArgument("--start-maximized");

            driver = new ChromeDriver(options);
        }

        
        protected void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); 
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing && driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }
                disposed = true;
            }
        }

        ~BaseTest()
        {
            Dispose(false);
        }
    }
}
