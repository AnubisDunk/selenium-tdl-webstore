using OpenQA.Selenium;
using SeleniumTests.Helpers;

namespace SeleniumTests.Pages
{
    public class Menu(IWebDriver driver)
    {
        private readonly IWebDriver driver = driver;

        IWebElement MenuButton => driver.FindByTestId("nav-menu-button");
        IWebElement StoreMainButton => driver.FindByTestId("nav-store-link");
        IWebElement HomeLink => driver.FindByTestId("home-link");
        IWebElement StoreLink => driver.FindByTestId("store-link");
        IWebElement CartLink => driver.FindByTestId("cart-link");
        IWebElement LanguageSelect => MenuButton.FindElements(By.CssSelector("button[type=button]"))[0];
        IWebElement LogoutButton => driver.FindByTestId("logout-button");

        public void Logout(){
            MenuButton.Click();
            LogoutButton.Click();
        }
        public bool IsLoggedIn(){
            return StoreMainButton.Displayed;
        }
    }
}
