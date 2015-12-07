using System;
using System.Text.RegularExpressions;

namespace Beer.DescriptionWriter.Console.Calculators
{
    public class VolumeCalculator
    {
        public static decimal GetVolInL(string volumeLine)
        {
            var conversionFactor = 1.00m;
            if (volumeLine.ToLower().Contains("galus"))
            {
                conversionFactor = 3.785m;
            }
            else if (volumeLine.ToLower().Contains("gal"))
            {
                conversionFactor = 4.54609m;
            }
            var digitsRegex = new Regex(@"\d+");
            Match m = digitsRegex.Match(volumeLine);
            return Convert.ToDecimal(m.Captures[0].Value) * conversionFactor;
        }
    }
}