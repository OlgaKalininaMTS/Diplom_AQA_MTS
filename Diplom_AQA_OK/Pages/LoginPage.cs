using Diplom_AQA_OK.Helpers;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class LoginPage : BasePage
    {
        private const string END_POINT = "";

        // Описание элементов
        private static readonly By EmailInputBy = By.CssSelector("[data-testid='textbox-login']");
        private static readonly By PswInputBy = By.CssSelector("[data-testid='textbox-password']");
        private static readonly By LoginInButtonBy = By.CssSelector("[data-testid='button-login']");
        private static readonly By ErrorLabelBy = By.XPath("//div[@class = 'sc-jIYCZY gxTmID']/p");

        // Инициализация класса

        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }
        
        public LoginPage(IWebDriver driver) : base(driver, false)
        {
        }
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        // Методы
        public IWebElement EmailInput => WaitsHelper.WaitForExists(EmailInputBy);
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
        public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

        public LoginPage IncorrectLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return this;
        }

        // Методы получения свойств
        public string GetErrorLabelText() => ErrorLabel.Text.Trim();
    }
}