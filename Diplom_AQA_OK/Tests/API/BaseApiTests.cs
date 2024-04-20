using Diplom_AQA_OK.Clients;
using NLog;
using Diplom_AQA_OK.Services;
using Allure.NUnit;

namespace Diplom_AQA_OK.Tests;

[Parallelizable(scope: ParallelScope.Fixtures)]
[AllureNUnit]

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