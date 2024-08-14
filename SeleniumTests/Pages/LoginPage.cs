
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTests.Helpers;

namespace SeleniumTests.Pages
{
    public class LoginPage(IWebDriver driver)
    {
        private readonly IWebDriver driver = driver;

        //locators

        IWebElement Container => driver.FindByTestId("login-page");
        IWebElement LoginBox => driver.FindByTestId("email-input");
        IWebElement PassBox => driver.FindByTestId("password-input");
        IWebElement SubmitButton => driver.FindByTestId("sign-in-button");
        IWebElement ErrorMessage => driver.FindByTestId("login-error-message");

        //actions

        public void Display() //bad practice
        {
            Assert.That(Container.Displayed, Is.EqualTo(true));
        }
        public void Login(string email, string password)
        {
            LoginBox.SendKeys(email);
            PassBox.SendKeys(password);
            SubmitButton.Click();
        }
        public void LoginFail()
        {
            LoginBox.SendKeys("Fail@fail.com");
            PassBox.SendKeys("Fail");
            SubmitButton.Click();
        }
        public bool isErrorMessageDisplayed()
        {
            return ErrorMessage.Displayed;
        }
    }
}