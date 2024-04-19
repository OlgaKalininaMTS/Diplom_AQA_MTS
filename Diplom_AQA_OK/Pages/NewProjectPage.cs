using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class NewProjectPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "123/dashboard";

        // Описание элементов
        private static readonly By TitleLabelNewProjBy = By.CssSelector("[data-testid='text-dashboard-header-content']");

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return TitleLabelNewProj.Displayed;
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

        public IWebElement TitleLabelNewProj => WaitsHelper.WaitForExists(TitleLabelNewProjBy);       
       
    }
}