using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        DashboardPage dashboardPage = new DashboardPage(Driver);

        // Проверка 
          Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin(Configurator.AppSettings.Username, "5454")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Either your email address or your password is wrong. Please try again or recover your password."));
    }
}