using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class OuncesConversionPage : PageBase
    {
        public OuncesConversionPage(IWebDriver _driver) : base(_driver) { }


        [FindsBy(How = How.XPath, Using = "//a[@class='typeConv unitConv unit2UnitConv' and text()= 'Ounces to Grams']")]
        private IWebElement OuncesToGramsBtn;


        public OuncesToGramsPage ClickOuncesToGramsBtn()
        {
            OuncesToGramsBtn.Click();

            OuncesToGramsPage ouncesToGramsPage = new OuncesToGramsPage(driver);
            return ouncesToGramsPage;
        }
    }
}

