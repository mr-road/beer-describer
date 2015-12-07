using System;
using System.Text.RegularExpressions;

namespace Beer.DescriptionWriter.Console.Calculators
{
    public class MassCalculator
    {
         /*
        1 lb = 16 oz = 0.453592 kg
        1 oz = 0.0283495 kg 
        */

        public static decimal ParseMassToKg(string mass)
        {
            decimal conversionFactor = 1.00m;

            if (mass.ToLower().Contains("lb"))
            {
                conversionFactor = 0.453592m;
            }
            else if (mass.ToLower().Contains("oz"))
            {
                conversionFactor = 0.0283495m;
            }
            else if (mass.ToLower().Contains("kg"))
            {
                conversionFactor = 1m;
            }
            else if(mass.ToLower().Contains("g"))
            {
                conversionFactor = 0.001m;
            }
            var digitsRegex = new Regex(@"\d+");
            Match m = digitsRegex.Match(mass);

            return Convert.ToDecimal(m.Captures[0].Value) * conversionFactor;
        }
    }
}