using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class MetersToFeetPage : PageBase
    {
        public MetersToFeetPage(IWebDriver _driver) : base(_driver) { }

        [FindsBy(How = How.XPath, Using = "//input[@class='inputField desktopField']")]
        private IWebElement InputField;

        [FindsBy(How = How.Id, Using = "answer")]
        private IWebElement AnswerLbl;

        [FindsBy(How = How.Id, Using = "format")]
        private IWebElement FormatList;

        [FindsBy(How = How.XPath, Using = "//option[text() = 'Decimal']")]
        private IWebElement DecimalOption;

        public void SelectDecimalFormat()
        {
            InputField.SendKeys(Keys.Space);

            FormatList.Click();
            DecimalOption.Click();
        }

        public float Convert(double Meters)
        {
            string resultStr;
            float resultNum;

            SelectDecimalFormat();

            InputField.SendKeys(Meters.ToString());
            
            resultStr = AnswerLbl.Text;

            ExtractMetersNum(ref resultStr);
            if (!float.TryParse(resultStr, out resultNum))
                throw new Exception("Extracting Feet number failed");

            return resultNum;
        }

        public void ExtractMetersNum(ref string result)
        {
            //Cut all characters before '=' including
            int index = result.IndexOf('=');
            result = result.Substring(index + 1);

            //Cut the ft symbol - 2 characters
            index = result.IndexOf('f');
            result = result.Substring(0, index);
        }
    }
}
