using OpenQA.Selenium;
namespace SeleniumTests.Pages
{
    class AllPages(IWebDriver driver)
    {
        private readonly IWebDriver driver = driver;

        public LoginPage LoginPage => new(driver);
        public MainPage MainPage => new(driver);
        public Menu MenuPage => new(driver);
    }

}