using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Helpers;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages.Project;

public abstract class ProjectBasePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{

    private static readonly By NameInputBy = By.CssSelector("[data-testid='textbox-name']");
    private static readonly By ProjectKeyBy = By.CssSelector("[data-testid='textbox-key']");
    private static readonly By ProjectDescriptionBy = By.CssSelector("[data-testid='textbox-description']");

    // Атомарные Методы

    public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);
    public IWebElement ProjectKey => WaitsHelper.WaitForExists(ProjectKeyBy);
    public IWebElement ProjectDescription => WaitsHelper.WaitForExists(ProjectDescriptionBy);

}