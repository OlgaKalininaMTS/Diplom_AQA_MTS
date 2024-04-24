using Diplom_AQA_OK.Clients;
using Diplom_AQA_OK.Models;
using RestSharp;

namespace Diplom_AQA_OK.Services;

public class PermissionsService : IPermissionsService
{
    private readonly RestClientExtended _client;

    public PermissionsService(RestClientExtended client)
    {
        _client = client;
    }

    public Task<RestResponse> GetPermissions()
    {
        var request = new RestRequest("api/v1/permission/me");

          // var permission = _client.ExecuteAsync<Permission>(request);
        //   return permission;
        return _client.ExecuteAsync(request);
    }

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}