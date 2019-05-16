using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class OuncesToGramsPage : PageBase
    {
        public OuncesToGramsPage(IWebDriver _driver) : base(_driver) { }

        [FindsBy(How = How.XPath, Using = "//input[@class='inputField desktopField']")]
        private IWebElement InputField;

        [FindsBy(How = How.Id, Using = "answer")]
        private IWebElement AnswerLbl;
                                                      


        public float Convert(double Ounces)
        {
            string resultStr;
            float resultNum;

            InputField.SendKeys(Ounces.ToString());
            resultStr = AnswerLbl.Text;

            ExtractGramsNum(ref resultStr);
            if (!float.TryParse(resultStr, out resultNum))
                throw new Exception("Extracting Ounces number failed");

            return resultNum;
        }

        public void ExtractGramsNum(ref string result)
        {
            //Cut all characters before '=' including
            int index = result.IndexOf('=');
            result = result.Substring(index + 1);

            //Cut the gram symbol 
            index = result.IndexOf('g');
            result = result.Substring(0, index);
        }
    }
}
