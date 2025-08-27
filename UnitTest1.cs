using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UpWorkTestsAutomation;

public class Tests
{
    private ChromeDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void TestGoogleSearch()
    {
        driver.Navigate().GoToUrl("https://www.google.com");

        IWebElement searchBox = driver.FindElement(By.Name("q"));
        searchBox.SendKeys("Selenium WebDriver");
        searchBox.Submit();

        IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }
}
