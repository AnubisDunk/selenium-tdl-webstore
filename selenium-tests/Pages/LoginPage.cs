
using NUnit.Framework;
using OpenQA.Selenium;
using selenium_tests.helpers;
namespace selenium_tests.Pages
{
    public class LoginPage(IWebDriver driver)
    {
        private readonly IWebDriver driver = driver;
        string Title => driver.Title;

        //locators
        IWebElement Container => driver.FindElement(Helper.FindByTestId("login-page"));
        IWebElement LoginBox => driver.FindElement(Helper.FindByTestId("email-input"));
        IWebElement PassBox => driver.FindElement(Helper.FindByTestId("password-input"));
        IWebElement SubmitButton => driver.FindElement(Helper.FindByTestId("sign-in-button"));

        //actions

    public void Display(){
        Assert.That(Container.Displayed, Is.EqualTo(true));
    }
    public void Login(string email, string password){
        LoginBox.SendKeys(email);
        PassBox.SendKeys(password);
        SubmitButton.Click();
    }

    }
}