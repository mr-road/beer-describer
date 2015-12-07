using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Beer.DescriptionWriter.Console.Calculators;
using Beer.Ingredients.Lookup;

namespace Beer.DescriptionWriter.Console.Parsers
{
    class HopParser
    {
        private static readonly Regex IngredientRegex = new Regex(@"([\d+\.]+\w+)[\t\s]+([\d+\w+\.\s+\(\)]+)");

        public static string Parse(List<string> recipe)
        {
            HopAdditions hopAdditions = new HopAdditions();
            decimal totalAlphaAcids = 0.0m;
            foreach (var line in recipe) {
                MatchCollection m = IngredientRegex.Matches(line);
                if (m.Count > 0) {
                    if (line.ToLower().Contains("min")) {
                        Hop hop = Hops.LookupHopByName(m[0].Groups[2].Value);

                        HopAddition ha = new HopAddition(hop);
                        ha.Quantity = MassCalculator.ParseMassToKg(m[0].Groups[1].Value);
                        ha.TimeOfAddition = 1;
                        totalAlphaAcids += ha.Quantity * ha.Hop.HopAcids.PercentageAlphaAcids;//ignoring utilization atm
                        hopAdditions.list.Add(ha);
                    }
                }
            }

            foreach (var ha in hopAdditions.list) {
                ha.PercentageOfHopBitterness = (ha.Quantity * ha.Hop.HopAcids.PercentageAlphaAcids / totalAlphaAcids) * 100;//ignoring utilization atm
                ha.PercentageOfHopOils = (ha.Quantity / totalAlphaAcids) * 100; //just plain wrong, but hey :)
            }

            return hopAdditions.ToString();
        }
    }

    /*
    Is it low coholumene if so plesant bitterness
        What is high ? >25%
        High Cohumulone tend to have an aggressive bitterness.
    is it very oily, if so strong aromas
        What is a lot?
        seems to be >1.7 ml/100g
    
        http://www.usahops.org/graphics/File/HGA%20BCI%20Reports/Variety%20Manual%207-24-12.pdf
        
        
        
        
        */


    public class HopAddition
    {
        public  Hop Hop { get; set; }

        public HopAddition(Hop hop)
        {
            Hop = hop;
        }

        public decimal Quantity { get; set; }
        public int TimeOfAddition { get; set; }
        public decimal PercentageOfHopBitterness { get; set; }
        public decimal PercentageOfHopOils { get; set; }
    }

    public class HopAdditions
    {
        public IList<HopAddition> list = new List<HopAddition>();

        public override string ToString()
        {
            var s = string.Join(",", list.Select(x => x.ToString()));
            return s;
        }
    }
}

