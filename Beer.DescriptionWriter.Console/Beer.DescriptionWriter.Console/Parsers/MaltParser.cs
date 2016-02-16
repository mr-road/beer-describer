using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Beer.DescriptionWriter.Console.Calculators;
using Beer.Ingredients.Lookup;

namespace Beer.DescriptionWriter.Console.Parsers
{
    public class MaltParser
    {
        private static readonly Regex IngredientRegex = new Regex(@"([\d+\.]+\w+)[\t\s]+([\d+\w+\.\s+\(\)\/\-]+)");

        public static string Parse(List<string> recipe, decimal volumeInGallons)
        {
            Fermentables fermentables = new Fermentables();
            decimal totalMass = 0.0m;
            foreach (var line in recipe)
            {
                MatchCollection m = IngredientRegex.Matches(line);
                if (m.Count > 0)
                {
                    if (!line.ToLower().Contains("min"))
                    {
                        var f = Malts.LookupFermentableByName( m[0].Groups[2].Value);
                        f.Quantity = MassCalculator.ParseMassToKg(m[0].Groups[1].Value);
                        totalMass += f.Quantity;
                        fermentables.list.Add(f);
                    }
                }
            }

            foreach (var fermentable in fermentables.list)
            {
                fermentable.PercentageOfMash = (fermentable.Quantity/totalMass)*100;
            }

            string description =
                ColourDescriber.DescribeColour(ColourCalculator.ColourOfBatchInSRM_Imperial(fermentables, volumeInGallons));

            decimal OG = OGCalculator.CalculateSG(fermentables, volumeInGallons);

            System.Console.WriteLine("Gravity:" + OG);

            return description;
            //return fermentables.ToString();
        }
    }

     public class Fermentables
    {
        public IList<Fermentable> list = new List<Fermentable>();

        public override string ToString()
        {
            var s = string.Join(",", list.Select(x => x.ToString()));
            return s;
        }
    }

    static class OGCalculator
    {
        //http://homebrew.stackexchange.com/questions/1434/wiki-how-do-you-calculate-original-gravity

        public static decimal CalculateSG(Fermentables fermentables, decimal volumeInGallons)
        {
            var assumedEfficency = 0.75m;
            decimal points = 0m;
            foreach (var malt in fermentables.list)
            {
                points += ((malt.Quantity * 2.2m) * ((malt.PotentialSg - 1.0m) * 1000)/volumeInGallons );
            }

            return 1.0m + (points/1000m)*assumedEfficency;
        }
    }
}