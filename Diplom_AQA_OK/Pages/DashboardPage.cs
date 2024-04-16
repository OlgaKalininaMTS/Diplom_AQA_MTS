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

        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    }
}