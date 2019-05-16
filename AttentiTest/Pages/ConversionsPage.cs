using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class ConversionsPage : PageBase
    {

        public ConversionsPage(IWebDriver _driver) : base(_driver) { }
        
        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv temperature bluebg']")]
        private IWebElement TemperatureBtn;
        
        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv weight bluebg']")]
        private IWebElement WeightBtn;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'typeConv length bluebg']")]
        private IWebElement LengthBtn;


        ///----

        public TemperatureConversionPage ClickTemperatureBtn()
        {
            TemperatureBtn.Click();

            TemperatureConversionPage temperatureConversionPage = new TemperatureConversionPage(driver);
            return temperatureConversionPage;
        }

        public WeightConversionPage ClickWeightBtn()
        {
            WeightBtn.Click();

            WeightConversionPage weightConversionPage = new WeightConversionPage(driver);
            return weightConversionPage;
        }

        public LengthConversionPage ClickLengthBtn()
        {
            LengthBtn.Click();

            LengthConversionPage lengthConversionPage = new LengthConversionPage(driver);
            return lengthConversionPage;
        }
    }
}
