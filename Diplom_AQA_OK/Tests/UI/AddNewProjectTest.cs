using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using Diplom_AQA_OK.Steps;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Tests;

public class AddNewProjectTest : BaseTest
{
    [Test]
    [Order(1)]
    [Category("Smoke")]
    [Category("Regression")]
    public void InvalidAddProjectTest()
    {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).TitleLabel.Displayed);

        DashboardPage dashboardPage = new DashboardPage(Driver);

        dashboardPage.IncorrectNewProject("Invalid Test Project", "123456789", "test");
    }
    /*
    [Test]
    [Order(2)]
    [Category("Smoke")]
    [Category("Regression")]
    public void SuccessfulAddProjectTest()
    {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).TitleLabel.Displayed);

        DashboardPage dashboardPage = new DashboardPage(Driver);

        dashboardPage.SuccessFulAddNewProject("New Test Project","123","test");        
    }
    */

    
}