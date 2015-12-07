using System;
using System.Text.RegularExpressions;

namespace Beer.DescriptionWriter.Console.Calculators
{
    public class TempCalculator
    {
        private static Regex _digitsRegex = new Regex(@"\d+");
        public static decimal GetMashTempInC(string mashTemp)
        {
            
            Match m = _digitsRegex.Match(mashTemp);
            var temp  = Convert.ToDecimal(m.Captures[0].Value);

            decimal TempC;

            if (mashTemp.Contains("F"))
            {
                TempC = (temp - 32m)/1.8m;
            }
            else if (mashTemp.Contains("C"))
            {
                TempC = temp;
            }
            else
            {
                TempC = temp - 273.16m;
            }

            if (TempC > 72 || TempC < 63)
            {
                System.Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine("I am not sure this is the mash temperature you are looking for, move along!");
                System.Console.WriteLine("Temp(C):" + TempC);
                System.Console.ResetColor();
            }

            return TempC;
        }
    }
}