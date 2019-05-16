using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class LengthConversionPage : PageBase
    {
        public LengthConversionPage(IWebDriver _driver) : base(_driver) { }

        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv unitConv' and text() = 'Meters']")]
        private IWebElement MetersBtn;


        public MetersConversionPage ClickMetersBtn()
        {
            MetersBtn.Click();

            MetersConversionPage metersConversionPage = new MetersConversionPage(driver);
            return metersConversionPage;
        }
    }
}
