using AttentiTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest
{
    public class Tests : TestBase
    {

        [SetUp]
        public void TestInit()
        {
            GetDriver().Url = "https://www.metric-conversions.org/";
        }

       

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void ConvertCelsiusTemperatureToFahrenheit(double celsius)
        {
            ConversionsPage conversionsPage = new ConversionsPage(GetDriver());

            TemperatureConversionPage temperatureConversionPage = conversionsPage.ClickTemperatureBtn();

            CelsiusConversionPage celsiusConversionPage = temperatureConversionPage.clickCelsiusBtn();

            CelsiusToFahrenheitPage celsiusToFahrenheitPage = celsiusConversionPage.ClickCelsiusToFahrenheitBtn();

            float webResult = celsiusToFahrenheitPage.Convert(celsius);
            float innerResult = Helper.ConvertCelsiusToFahrenheit(celsius);

            Assert.IsTrue(webResult.ToString() == innerResult.ToString(), "\nActual Result: " + webResult + "\nExpected Result: " + innerResult + "\nFormula: "+ Helper.FormulaCelsiusToFahrenheit +"\n\n");
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void ConvertOuncesToGrams(double ounces)
        {
            ConversionsPage conversionsPage = new ConversionsPage(GetDriver());

            WeightConversionPage weightConversionPage = conversionsPage.ClickWeightBtn();

            OuncesConversionPage ouncesConversionPage = weightConversionPage.ClickOuncesBtn();

            OuncesToGramsPage ouncesToGramsPage = ouncesConversionPage.ClickOuncesToGramsBtn();

            float webResult = ouncesToGramsPage.Convert(ounces);
            float innerResult = Helper.ConvertOuncesToGrams(ounces);

            Assert.IsTrue(webResult.ToString() == innerResult.ToString(), "\nActual Result: " + webResult +"\nExpected Result: " + innerResult + "\nFormula: " + Helper.FormulaOuncesToGrams + "\n\n");
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void ConvertMetersToFeet(double meters)
        {
            ConversionsPage conversionsPage = new ConversionsPage(GetDriver());

            LengthConversionPage lengthConversionPage = conversionsPage.ClickLengthBtn();

            MetersConversionPage metersConversionPage = lengthConversionPage.ClickMetersBtn();

            MetersToFeetPage metersToFeetPage = metersConversionPage.ClickMetersToFeetBtn();

            float webResult  = metersToFeetPage.Convert(meters);
            float innerResult = Helper.ConvertMetersToFeet(meters);

            Assert.IsTrue(webResult.ToString() == innerResult.ToString(), "\nActual Result: " + webResult + "\nExpected Result: " + innerResult + "\nFormula: " + Helper.FormulaMetersToFeet + "\n\n");
        }


    }
}
