using Diplom_AQA_OK.Elements;
using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class NewProjectPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "settings/projects";
        

        // Описание элементов
        private static readonly By TitleLabelNewProjBy = By.CssSelector("[data-testid='text-dashboard-header-content']");
        //private static readonly By DeleteProjectButtonBy = By.XPath("//span[contains(text(), '123')]");
        private static readonly By ConfirmDeleteButtonBy = By.CssSelector("button.sc-hIPBNq.ghNoLp");

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
       // public Button DeleteButton => new Button(Driver, DeleteButtonBy);
        public Button ConfirmDeleteButton => new Button(Driver, ConfirmDeleteButtonBy);

       /* public NewProjectPage DeleteNewProject()
        {
            DeleteButton.Click();
            ConfirmDeleteButton.Click();

            return new NewProjectPage(Driver);
        }*/

    }
}