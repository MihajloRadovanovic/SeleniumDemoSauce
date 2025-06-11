SauceDemo UI Test Automation (Selenium + C#)

This project is a set of UI automation tests for [SauceDemo](https://www.saucedemo.com/), a demo e-commerce site.  
The tests are written in **C#** using **Selenium WebDriver** and help verify key features like login and shopping cart functionality.



 What’s Covered?

Login Tests
- Successful login with valid credentials
- Error message on invalid login

 Cart Tests
- Add one item and check cart shows `1`
- Add multiple items and verify the correct count
- Remove more items added and make sure the cart is empty
- Remove one item and make sure the cart is empty



Tech Stack

- **Language:** C#
- **Automation:** Selenium WebDriver
- **Test Framework:** NUnit
- **IDE:** Visual Studio 2022

---

How to Get Started

Prerequisites
Make sure you have:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022 or later
- ChromeDriver (or the WebDriver for your preferred browser)

Setup Instructions
1. Clone this repo
2. Open the solution in Visual Studio
3. Restore NuGet packages:
   - `Selenium.WebDriver`
   - `Selenium.Support`
   - `NUnit`
   - `NUnit3TestAdapter`
4. Run the tests using Test Explorer or from the terminal:
   ```bash
   dotnet test
