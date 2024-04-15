using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Pages;
using Diplom_AQA_OK.Steps;

namespace Diplom_AQA_OK.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage _loginPage = new LoginPage(Driver);
        _loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
        _loginPage.PswInput.SendKeys(Configurator.AppSettings.Password);
        _loginPage.ClickLoginInButton();

        DashboardPage dashboardPage = new DashboardPage(Driver);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(
            new UserSteps(Driver)
                .IncorrectLogin(Configurator.AppSettings.Username, "123")
                .GetErrorLabelText(),
            Is.EqualTo("Either your email address or your password is wrong. Please try again or recover your password."));
    }
}