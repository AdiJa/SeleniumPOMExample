using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class TemperatureConversionPage : PageBase
    {
        public TemperatureConversionPage(IWebDriver _driver) : base(_driver) { }


        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv unitConv' and text() = 'Celsius']")]
        private IWebElement CelsiusBtn;


        public CelsiusConversionPage clickCelsiusBtn()
        {
            CelsiusBtn.Click();

            CelsiusConversionPage celsiusConversionPage = new CelsiusConversionPage(driver);
            return celsiusConversionPage;
        }

    }
}
