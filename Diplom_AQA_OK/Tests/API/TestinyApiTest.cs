using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Models;
using NLog;
using System.Net;

namespace Diplom_AQA_OK.Tests.API;

public class TestinyApiTest : BaseApiTest
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected Project _project;

    [Test]
    [Order(1)]
    [Category("Smoke")]
    [Category("Regression")]
    public void AddProjectTest()
    {
        _project = new Project
       // Project project = new Project
        {
            ProjectName = "Test Api Project 3",
            ProjectKey = "56661",
            Description = "Test Api Project 3 description"
        };

        var newProject = ProjectService!.AddProject(_project);

        // Блок проверок
        Assert.Multiple(() =>
        {
            Assert.That(newProject.Result.ProjectName, Is.EqualTo(_project.ProjectName));
            Assert.That(newProject.Result.ProjectKey, Is.EqualTo(_project.ProjectKey));
            Assert.That(newProject.Result.Description, Is.EqualTo(_project.Description));
        });

        _project = newProject.Result;
        _logger.Info(_project.ToString);
    }

    [Test]
    [Order(2)]
    [Category("Regression")]
    public void GetProjectsTest()
    {
        var getprojectsInfo = ProjectService!.GetProjects();

        
    }

    /*
    [Test]
    [Order(2)]
    [Category("Regression")]
    public void GetProjectTest()
    {
       // _logger.Info(ProjectService!.GetProject(25));

         var actualProject = ProjectService!.GetProject(_project.Id);

        
            Assert.That(actualProject.Result.ProjectName, Is.EqualTo(_project.ProjectName));
            Assert.That(actualProject.Result.ProjectKey, Is.EqualTo(_project.ProjectKey));
            Assert.That(actualProject.Result.Description, Is.EqualTo(_project.Description));
       

        _project = actualProject.Result;
        // _logger.Info(_project.ToString);
    }
    */
}

