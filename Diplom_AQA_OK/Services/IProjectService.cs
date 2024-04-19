using Diplom_AQA_OK.Models;
using System.Net;

namespace Diplom_AQA_OK.Services;

public interface IProjectService
{
    Task<Project> GetProject(int projectId);
    Task<Project> AddProject(Project project);
    Task<Projects> GetProjects();
    HttpStatusCode DeleteProject(string projectId);
    

}