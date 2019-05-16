using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class WeightConversionPage : PageBase
    {
        public WeightConversionPage(IWebDriver _driver) : base(_driver) { }


        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv unitConv' and text() ='Ounces']")]
        private IWebElement OuncesBtn;


        public OuncesConversionPage ClickOuncesBtn()
        {
            //ScrollToElement(OuncesBtn);
            OuncesBtn.Click();

            OuncesConversionPage ouncesConversionPage = new OuncesConversionPage(driver);
            return ouncesConversionPage;
        }
    }
}
