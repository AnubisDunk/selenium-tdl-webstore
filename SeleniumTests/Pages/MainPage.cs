using OpenQA.Selenium;
using SeleniumTests.Helpers;

namespace SeleniumTests.Pages
{
    public class MainPage(IWebDriver driver)
    {
        private readonly IWebDriver driver = driver;

        IWebElement Container => driver.FindByTestId("product-list");
        
    }
}
