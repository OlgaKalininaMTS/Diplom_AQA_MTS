using System.Net;
using Diplom_AQA_OK.Models;
using RestSharp;
using Diplom_AQA_OK.Clients;

namespace Diplom_AQA_OK.Services;

public class ProjectService : IProjectService, IDisposable
{
    private readonly RestClientExtended _client;

    public ProjectService(RestClientExtended client)
    {
        _client = client;
    }

    public Task<Project> GetProject(int projectId)
    {
        var request = new RestRequest("api/v1/project/{project_id}")
            .AddUrlSegment("project_id", projectId);

        return _client.ExecuteAsync<Project>(request);
    }
    public Task<Projects> GetProjects()
    {
        var request = new RestRequest("api/v1/project");

        var projects = _client.ExecuteAsync<Projects>(request);
        return projects;
    }

    public Task<Project> AddProject(Project project)
    {
        var request = new RestRequest("api/v1/project", Method.Post)
            .AddJsonBody(project);

        return _client.ExecuteAsync<Project>(request);
    }   

    public HttpStatusCode DeleteProject(string projectId)
    {
        var request = new RestRequest("api/v1/project/{project_id}", Method.Post)
            .AddUrlSegment("project_id", projectId)
            .AddJsonBody("{}");

        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
    
}