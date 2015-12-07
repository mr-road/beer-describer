using System.Collections.Generic;
using Beer.DescriptionWriter.Console.Calculators;

namespace Beer.DescriptionWriter.Console.Parsers
{
    internal class RecipeParser
    {
        private readonly List<string> _recipe;
        private string _name;
        private decimal _volumeLiters;
        private string _mashDescription;
        private string _maltDescription;

        public RecipeParser(List<string> recipe)
        {
            _recipe = recipe;
            ParseName();
            ParseBatchSize();
            ParseMashTemp();
            ParseMalts();
        }

        private void ParseMalts()
        {
            _maltDescription = MaltParser.Parse(_recipe, _volumeLiters/4.454m);
        }


        public void PrintDescription()
        {
            System.Console.WriteLine("Name: " + _name);
           // System.Console.WriteLine("Vol (l): " + _volumeLiters);
            System.Console.Write("Description: " + _maltDescription + " ");
            System.Console.WriteLine( _mashDescription);
        }

        private void ParseName()
        {
            _name = _recipe[0];
        }

        private void ParseBatchSize()
        {
            _volumeLiters = VolumeCalculator.GetVolInL(_recipe[1]);
        }

        private void ParseMashTemp()
        {
            var tempC = TempCalculator.GetMashTempInC(_recipe[2]);
            _mashDescription = MashTempDescriber.Describe(tempC);
        }

    }

    internal class MashTempDescriber
    {
        public static string Describe(decimal tempC)
        {
            if (tempC < 65)
            {
                return "A light body with a clean mouth feel.";
            }
            if(tempC > 67 && tempC < 69)
            {
                return "The body is rich, deep and full of depth.";
            }
            if(tempC >= 69)
            {
                return "The body is like treacle mixed with jello, rather chewy.";
            }
            return "Pleasantly smooth.";
        }
    }
}