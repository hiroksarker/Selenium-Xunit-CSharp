using SeleniumLearningApp.Page;
using SeleniumLearningApp.Test.Base;
using Xunit;

namespace SeleniumLearningApp.Test.Login
{
    [Trait("Login", "Successful Login")]
    public class LoginTests : BaseTests
    {

        [Fact]
        public void TestSuccessfulLogin()
        {
            LoginPage loginPage = homePage.ClickFormAuthentication();
            loginPage.SetUsername("tomsmith");
            loginPage.SetPassword("SuperSecretPassword!");

            SecureAreaPage secureAreaPage = loginPage.ClickLoginButton();
            Assert.True(secureAreaPage.GetAlertText().Contains("You logged into a secure area!"), "Alert text is incorrect.");
        }
        
    }
}
