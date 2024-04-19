using Diplom_AQA_OK.Services;
using NLog;

namespace Diplom_AQA_OK.Tests.API;

public class TestinyApiTestTTT : BaseApiTest
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
    // protected Project _project;

    [Test]
    [Order(1)]
    [Category("Smoke")]
    [Category("Regression")]
    public void GetPermissionsTest()
    {
      //  var permissionsInfo = PermissionsService?.GetPermissions();


    }
}

