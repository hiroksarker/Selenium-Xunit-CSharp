using OpenQA.Selenium;
using SeleniumLearningApp.Test.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearningApp.Page
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage ClickFormAuthentication()
        {
            ClickLink("Form Authentication");
            return new LoginPage(driver);
        }

        private void ClickLink(string linkText)
        {
            driver.FindElement(By.LinkText(linkText)).Click();
        }


    }
}
