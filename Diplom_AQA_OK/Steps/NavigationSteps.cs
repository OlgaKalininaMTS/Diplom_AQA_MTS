using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;
using Diplom_AQA_OK.Models;
using Allure.NUnit.Attributes;

namespace Diplom_AQA_OK.Steps;

public class NavigationSteps(IWebDriver driver) : BaseSteps(driver)
{
    [AllureStep]
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
    }

    [AllureStep]
    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver);
    }

    [AllureStep]
    public void NavigateToAddProjectPage()
    {
        new NewProjectPage(Driver, true);
    }

    [AllureStep]
    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }
    public T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);

        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}