using NLog;
using NLogExample.Core;

namespace Diplom_AQA_OK.Tests;

[SetUpFixture]
public class BaseSuiteLog
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    [OneTimeSetUp]
    public static void SuiteSetup()
    {
        new NLogConfig().Config();
        Logger.Info("NLog setted up.");
    }
}