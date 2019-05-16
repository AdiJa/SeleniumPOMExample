using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class CelsiusConversionPage : PageBase
    {
        public CelsiusConversionPage(IWebDriver _driver) : base(_driver) { }


        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv unitConv unit2UnitConv' and text() = 'Celsius to Fahrenheit']")]
        private IWebElement CelsiusToFahrenheitBtn;


        public CelsiusToFahrenheitPage ClickCelsiusToFahrenheitBtn()
        {
            CelsiusToFahrenheitBtn.Click();

            CelsiusToFahrenheitPage celsiusToFahrenheitPage = new CelsiusToFahrenheitPage(driver);
            return celsiusToFahrenheitPage;
        }
    }
}
