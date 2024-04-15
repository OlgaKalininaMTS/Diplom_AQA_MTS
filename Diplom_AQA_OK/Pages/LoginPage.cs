using Diplom_AQA_OK.Helpers;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";

        // Описание элементов
        private static readonly By EmailInputBy = By.Name("email");
        private static readonly By PswInputBy = By.Name("password");
        private static readonly By LoginInButtonBy = By.CssSelector("[data-testid='button-login']");
        private static readonly By ErrorLabelBy = By.XPath("//div[@class = 'sc-hiTDLB dpizrC']/p");

        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        // Методы
        public IWebElement EmailInput => WaitsHelper.WaitForExists(EmailInputBy);
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
       public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

        // Методы действий с элементами
        public void ClickLoginInButton() => LoginInButton.Click();

        // Методы получения свойств
        public string GetErrorLabelText() => ErrorLabel.Text.Trim();
    }
}