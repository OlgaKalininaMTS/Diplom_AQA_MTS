using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Pages;
using Diplom_AQA_OK.Steps;

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