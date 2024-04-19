using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class ProfilePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "settings/profile";

        // Описание элементов
        private static readonly By TitleLabelProfileBy = By.XPath("//div[@class = 'sc-hJdEdJ bqYldc']");

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return TitleLabelProfile.Displayed;
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

        public IWebElement TitleLabelProfile => WaitsHelper.WaitForExists(TitleLabelProfileBy);

    }
}