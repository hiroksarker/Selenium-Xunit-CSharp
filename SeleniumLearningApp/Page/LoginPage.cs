using OpenQA.Selenium;

namespace SeleniumLearningApp.Page
{
    public class LoginPage
    {
        private IWebDriver driver;

        protected By UsernameField = By.Id("username");
        protected By PasswordField = By.Id("password");
        protected By LoginButton = By.CssSelector("#login button");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SetUsername(string username)
        {
            driver.FindElement(UsernameField).SendKeys(username);
        }

        public void SetPassword(string password)
        {
            driver.FindElement(PasswordField).SendKeys(password);
        }

        public SecureAreaPage ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();
            return new SecureAreaPage(driver);

        }


    }
}
