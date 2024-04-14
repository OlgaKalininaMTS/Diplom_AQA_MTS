using Diplom_AQA_OK.Helpers;
using Diplom_AQA_OK.Pages;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Pages;

public class DashboardPage : BasePage
{
    private static string END_POINT = "dashboard";

    // Описание элементов
     private static readonly By TitleLabelBy = By.XPath("//*[contains(text(), 'Thank you for registering!')]");
    
    public MenuPage MenuPage;

    // Инициализация класса
    public DashboardPage(IWebDriver driver) : base(driver)
    {
        MenuPage = new MenuPage(Driver);
    }
   
    protected override string GetEndpoint()
    {
        return END_POINT;
    }

      public override bool IsPageOpened()
      {
          return TitleLabel.Displayed;
    }
    
   
    // Атомарные Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
}