using Diplom_AQA_OK.Pages;
using NLog;

namespace Diplom_AQA_OK.Tests;

public class LoginTest : BaseTest
{
    protected static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    [Test]
    [Category("Smoke")]
    [Category("Regression")]
      public void SuccessfulLoginTest()
      {
        Logger.Log(LogLevel.Info, "This is an informational message...");

        Assert.That(_navigationSteps.SuccessfulLogin(Admin).TitleLabel.Displayed);
      }

    [Test]
    [Category("Smoke")]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("oa-kalinina@yandex.ru", "123")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Either your email address or your password is wrong. Please try again or recover your password."));
    }

    [Test]
    [Category("Smoke")]
    [Category("Regression")]
    public void SuccessfulAddFileTest()
    {
        Logger.Log(LogLevel.Info, "This is an informational message...");

        Assert.That(_navigationSteps.SuccessfulLogin(Admin).TitleLabel.Displayed);
        DashboardPage dashboardPage = new DashboardPage(Driver);
    }
}