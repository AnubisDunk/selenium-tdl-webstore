using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_tests.Pages;

namespace selenium_tests;

public class WebstoreTests
{
    [Test]
    public void LoginTest()
    {
        var options = new ChromeOptions();
        options.AddArguments(["--start-maximized","--disable-search-engine-choice-screen"]);
        IWebDriver driver = new ChromeDriver(options);
        //LoginPage
        //driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://coe-webstore.tdlbox.com/sign-in");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        var title = driver.Title;
        Assert.That(title, Is.EqualTo("Sign in"));
       
        //Assert.That(PageObjects.Login.submitButton.Displayed, Is.EqualTo(true));
        // loginBox.SendKeys("joe@doe.com");
        // passBox.SendKeys("joedoe");
        // submitButton.Click();
        Thread.Sleep(3000);
        driver.Quit();
    }
}
