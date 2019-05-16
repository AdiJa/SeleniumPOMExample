using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiTest
{
    class Helper
    {
        public static string FormulaCelsiusToFahrenheit { get {return "°F = °C * 1.800000 + 32"; } }
        public static string FormulaOuncesToGrams { get { return "g = oz * 28.34952"; } }
        public static string FormulaMetersToFeet { get { return "ft = m * 3.280840"; } }

       

        public static float ConvertCelsiusToFahrenheit(double celsius)
        {
            return (float)(celsius * 1.800000 + 32);
        }

        public static float ConvertOuncesToGrams(double ounces)
        {
            return (float)(ounces * 28.34952);
        }

        public static float ConvertMetersToFeet(double meters)
        {
            return (float)(meters * 3.280840);
        }

    }
}
