using Diplom_AQA_OK.Clients;
using NLog;
using Diplom_AQA_OK.Services;

namespace Diplom_AQA_OK.Tests;

public class BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;

    [OneTimeSetUp]
    public void SetUpApi()
    {
        var restClient = new RestClientExtended();
        ProjectService = new ProjectService(restClient);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        ProjectService?.Dispose();
    }
}