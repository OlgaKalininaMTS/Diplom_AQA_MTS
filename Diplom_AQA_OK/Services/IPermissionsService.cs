using Diplom_AQA_OK.Models;
using RestSharp;
using System.Net;

namespace Diplom_AQA_OK.Services;

public interface IPermissionsService
{
    Task<RestResponse> GetPermissions();   
}