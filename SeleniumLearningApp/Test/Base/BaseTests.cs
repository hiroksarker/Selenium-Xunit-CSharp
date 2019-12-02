using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumLearningApp.Page;
using System;

namespace SeleniumLearningApp.Test.Base
{
    public class BaseTests : IDisposable
    {
        private IWebDriver driver;
        protected HomePage homePage;
        
        public BaseTests()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
                homePage = new HomePage(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while starting chrome..." + e);
            }

        }

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while stoping chrome" + e);
            }
        }


    }
}
