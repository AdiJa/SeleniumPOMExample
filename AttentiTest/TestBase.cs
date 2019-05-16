using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest
{
    [TestFixture]
    public abstract class TestBase
    {
        private WebDriverWait wait;
        private IWebDriver driver;


        [OneTimeSetUp]
        public void InitClass()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            driver.Close();
            driver.Quit();
        }

        protected IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
