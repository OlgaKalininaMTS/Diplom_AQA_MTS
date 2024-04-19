using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using Diplom_AQA_OK.Steps;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Tests;

public class AddNewProjectTest : BaseTest
{
   [Test]
    public void SuccessfulAddProjTest()
    {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).TitleLabel.Displayed);

        DashboardPage dashboardPage = new DashboardPage(Driver);

        dashboardPage.SuccessFulAddNewProj("New Test Project","123","test");
    }
}