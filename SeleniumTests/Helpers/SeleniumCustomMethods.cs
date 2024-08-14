using OpenQA.Selenium;
namespace SeleniumTests.Helpers
{
    public static class SeleniumCustomMethods
    {
        public static IWebElement FindByTestId(this IWebDriver driver, string id)
        {
            return driver.FindElement(By.CssSelector($"[data-testid=\"{id}\"]"));
        }
    }
}
