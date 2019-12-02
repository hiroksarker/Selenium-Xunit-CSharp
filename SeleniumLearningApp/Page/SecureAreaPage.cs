using OpenQA.Selenium;

namespace SeleniumLearningApp.Page
{
    public class SecureAreaPage
    {
        private IWebDriver driver;

        protected By StatusAlert = By.Id("flash");

        public SecureAreaPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetAlertText()
        {
            return driver.FindElement(StatusAlert).Text;
        }
    }
}
