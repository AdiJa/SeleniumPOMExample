using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class MetersConversionPage : PageBase
    {
        public MetersConversionPage(IWebDriver _driver) : base(_driver) { }


        [FindsBy(How = How.XPath, Using = "//a[text() = 'Meters to Feet']")]
        private IWebElement MetersToFeetBtn;


        public MetersToFeetPage ClickMetersToFeetBtn()
        {
            MetersToFeetBtn.Click();

            MetersToFeetPage metersToFeetPage = new MetersToFeetPage(driver);
            return metersToFeetPage;
            ;
        }
    }
}
