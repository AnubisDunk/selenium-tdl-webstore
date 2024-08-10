using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_tests;

public class WebstoreTests
{
    [Test]
    public void LoginTest()
    {
        IWebDriver driver = new ChromeDriver();
        //driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://coe-webstore.tdlbox.com/sign-in");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        var title = driver.Title;
        var loginBox = driver.FindElement(By.CssSelector("[data-testid=\"email-input\"]"));
        loginBox.SendKeys("joe@doe.com");
        driver.Quit();

    }
}
