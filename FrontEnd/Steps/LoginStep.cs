using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

[Binding]
public class LoginStep
{
    private IWebDriver driver;

    [Given(@"User is on the website ""(.*)""")]
    public void VisitWebsite(string website)
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(website);
    }

    [When(@"User enter with the username ""(.*)"" and password ""(.*)""")]
    public void LoginWith(string username, string password)
    {

    }
}
