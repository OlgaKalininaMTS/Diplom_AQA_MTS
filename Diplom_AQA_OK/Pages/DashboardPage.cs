using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class DashboardPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "dashboard";

        // Описание элементов
        private static readonly By TitleLabelBy = By.XPath("//*[contains(text(), 'Thank you for registering!')]");
        private static readonly By AddProjButtonBy = By.CssSelector("[data-testid='button-create-project']");
        private static readonly By TitleAddProjBy = By.CssSelector("[data-testid='section-project_edit']");
        private static readonly By NameNewProjBy = By.CssSelector("[data-testid='textbox-name']");
        private static readonly By ProjectKeyBy = By.CssSelector("[data-testid='textbox-key']");
        private static readonly By ProjectDescriptionBy = By.CssSelector("[data-testid='textbox-description']");
        private static readonly By CreateProjectButtonBy = By.CssSelector("[data-testid='button-save-entity']");

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return TitleLabel.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
        /*public override bool IsPageOpened()
        {
            return TitleAddProj.Displayed;
        }*/

        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement AddProjButton => WaitsHelper.WaitForExists(AddProjButtonBy);
        public IWebElement TitleAddProj => WaitsHelper.WaitForExists(TitleAddProjBy);
        public IWebElement NameNewProj => WaitsHelper.WaitForExists(NameNewProjBy);
        public IWebElement ProjectKey => WaitsHelper.WaitForExists(ProjectKeyBy);
        public IWebElement ProjectDescription => WaitsHelper.WaitForExists(ProjectDescriptionBy);
        public IWebElement CreateProjectButton => WaitsHelper.WaitForExists(CreateProjectButtonBy);

        public DashboardPage SuccessFulAddNewProj(string nameproj, string projkey, string projdesc)
        {
            AddProjButton.Click();
            NameNewProj.SendKeys(nameproj);
            ProjectKey.SendKeys(projkey);
            ProjectDescription.SendKeys(projdesc);
            CreateProjectButton.Click();

            return new DashboardPage(Driver);
        }
    }
}