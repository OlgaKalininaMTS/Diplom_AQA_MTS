using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Models;
using NLog;
using System.Net;

namespace Diplom_AQA_OK.Tests.API;

public class TestinyApiTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project;

    [Test]
    [Order(1)]
    public void CreateProjectApiTest()
    {
        _project = new Project
        {
            ProjectName = $"Test33 {DateTime.Now}",
            Description = "Test Description 33",
            ProjectKey = "333"
        };

        var actualProject = ProjectService!.AddProject(_project);

        Assert.That(actualProject.Result.ProjectName, Is.EqualTo(_project.ProjectName));


        _project = actualProject.Result;
    }

    [Test]
    [Order(2)]
    public void GetProjectApiTest()
    {
        var getProject = ProjectService!.GetProject(_project.Id);

        Assert.Multiple(() =>
        {
            Assert.That(getProject.Result.ProjectName, Is.EqualTo(_project.ProjectName));
            Assert.That(getProject.Result.Description, Is.EqualTo(_project.Description));
            Assert.That(getProject.Result.Id, Is.EqualTo(_project.Id));
        });
    }

    [Test]
    [Order(3)]
    public void SuccessDeleteProject()
    {
        var successDelProject = ProjectService!.DeleteProject(_project.Id);

        Assert.That(successDelProject, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    [Order(4)]
    public void InvalidDeleteProject()
    {
        var invalidDeleteProject = ProjectService!.DeleteProject(_project.Id);
        Assert.That(invalidDeleteProject, Is.EqualTo(HttpStatusCode.NotFound));

    }


}