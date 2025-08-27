using OpenQA.Selenium;

public class HomePO
{
    private IWebDriver driver;

    private By usernameField = By.XPath("//input[@name='username']");
    private By passwordField = By.XPath("//input[@name='password']");
    private By loginButton = By.XPath("//button[@type='submit']");

    public HomePO(IWebDriver driver)
    {
        this.driver = driver;
    }

}