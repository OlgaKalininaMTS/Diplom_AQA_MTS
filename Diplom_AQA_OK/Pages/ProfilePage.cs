using Diplom_AQA_OK.Elements;
using Diplom_AQA_OK.Helpers;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class ProfilePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "settings/profile";

        // Описание элементов
        private static readonly By TitleLabelProfileBy = By.XPath("//div[@class = 'sc-hJdEdJ bqYldc']");
        private static readonly By NewAvatarButtonBy = By.XPath("//*[@data-testid='section-drop-area']/button");
        private static readonly By RemoveAvatarButtonBy = By.XPath("//*[@data-testid='section-drop-area']/div/button");

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
        public UIElement NewAvatarButton => new UIElement(Driver, NewAvatarButtonBy);
        public Button RemoveAvatarButton => new Button(Driver, RemoveAvatarButtonBy);     
    }
}