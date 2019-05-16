using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest.Pages
{
    public class PageBase
    {
        protected IWebDriver driver;
        Actions action;

        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            driver = _driver;
        }

        public void ScrollToElement(IWebElement elem)
        {
            action = new Actions(driver);

            action.MoveToElement(elem, 0, 500);
            action.Build().Perform();
            action.Release();
        }
    }
}
