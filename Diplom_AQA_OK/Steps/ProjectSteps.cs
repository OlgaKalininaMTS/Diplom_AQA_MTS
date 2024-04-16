using OpenQA.Selenium;
using Diplom_AQA_OK.Pages.Project;
using Diplom_AQA_OK.Models;
using Diplom_AQA_OK.Pages.ProjectPages;

namespace Diplom_AQA_OK.Steps;

public class ProjectSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);

        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.ProjectKey.SendKeys(project.ProjectKey);
        AddProjectPage.ProjectDescription.SendKeys(project.Description);

        AddProjectPage.AddButton.Click();

        return new ProjectPage(Driver);
    }
}