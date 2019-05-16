using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
     public class CelsiusToFahrenheitPage : PageBase
    {
        public CelsiusToFahrenheitPage(IWebDriver _driver) : base(_driver) { }

        [FindsBy(How = How.XPath, Using = "//input[@class='inputField desktopField']")]
        private IWebElement InputField;

        [FindsBy(How = How.Id, Using = "answer")]
        private IWebElement AnswerLbl;




        public float Convert(double celsius)
        {
            string resultStr;
            float resultNum;

            InputField.SendKeys(celsius.ToString());
            resultStr = AnswerLbl.Text;

            ExtractFahrenheitNum(ref resultStr);
            if (!float.TryParse(resultStr, out resultNum))
                throw new Exception("Extracting Fahrenheit number failed");

            return resultNum;
        }

        public void ExtractFahrenheitNum(ref string result)
        {
            //Cut all characters before '=' including
            int index = result.IndexOf('=');
           result = result.Substring(index + 1);

            //Cut the fahrenheit symbol - 2 characters
            index = result.IndexOf('F');
            result = result.Substring(0, index - 1);
        }
    }
}
