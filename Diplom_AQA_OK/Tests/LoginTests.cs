using Diplom_AQA_OK.Pages;

namespace Diplom_AQA_OK.Tests;

public class LoginTest : BaseTest
{
      [Test]
      public void SuccessfulLoginTest()
      {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).TitleLabel.Displayed);
      }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("oa-kalinina@yandex.ru", "123")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Either your email address or your password is wrong. Please try again or recover your password."));
    }    
}