using DotNetEnv;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;


namespace SeleniumTests;

public class WebstoreTests
{
    private IWebDriver _driver;
    private AllPages _pages;

    private static string _email, _password;
    [SetUpFixture]
    public class TestsSetupClass
    {
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            Env.Load();
            Env.TraversePath().Load();
            _email = Environment.GetEnvironmentVariable("Email") ?? "test@email.com";
            _password = Environment.GetEnvironmentVariable("Password") ?? "test";
        }

        [OneTimeTearDown]
        public void GlobalTeardown()
        {
            // Do logout here
        }
    }
    [SetUp]
    protected void SetUp()
    {
        var options = new ChromeOptions();
        options.AddArguments(["--start-maximized", "--disable-search-engine-choice-screen"]);
        _driver = new ChromeDriver(options);
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://coe-webstore.tdlbox.com/sign-in");
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        _pages = new(_driver);
        _pages.LoginPage.Display();
        _pages.LoginPage.Login(_email, _password);
    }

    [Test]
    [Description("Sign-in webstore with right correct credentials")]
    public void LoginTest()
    {
        var isLoggedIn = _pages.MenuPage.IsLoggedIn();
        Assert.That(isLoggedIn);
    }
    [Test]
    [Description("Sign-in webstore with wrong credentials")]
    public void LoginTestWrong()
    {
        _pages.MenuPage.Logout();
        _pages.LoginPage.LoginFail();
        var isLoggedIn = _pages.LoginPage.isErrorMessageDisplayed;
        Assert.That(isLoggedIn);
    }
    [Test]
    [Description("Observe one item")]
    public void ObserveItem()
    {
       // Assert.That(Container.Displayed, Is.EqualTo(true));
    }

    [TearDown]
    public void TearDown()
    {
        Console.Write("Test completed");
        //Thread.Sleep(3000);
        _driver.Quit();
    }
}
