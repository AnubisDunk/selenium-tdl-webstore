using OpenQA.Selenium;
namespace selenium_tests.helpers
{
    public static class Helper
    {
        public static By FindByTestId(string id)
        {
            return By.CssSelector($"[data-testid=\"{id}\"]");
        }
    }
}
