using Diplom_AQA_OK.Helpers;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages.Project;

public class ProjectPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/overview";

    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[contains(@class, 'page_title') and contains(text(), 'Projects')]");
    private static readonly By SuccessMessageBy = By.ClassName("message-success");

    protected override bool EvaluateLoadedStatus()
    {
        return Title.Displayed;
    }
    
    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
    public IWebElement SuccessMessage => WaitsHelper.WaitForExists(SuccessMessageBy);
}