using System;
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

        public static string Parse(List<string> recipe, decimal @decimal)
        {
            HopAdditions hopAdditions = new HopAdditions();
            decimal totalAlphaAcids = 0.0m;
            foreach (var line in recipe) {
                MatchCollection m = IngredientRegex.Matches(line);
                if (m.Count > 0) {
                    if (line.ToLower().Contains("min"))
                    {
                        var details = m[0].Groups[2].Value.Split('\t');
                        if (details.Length == 1)
                        {
                            details = m[0].Groups[2].Value.Split(' ');
                        }

                        Hop hop = Hops.LookupHopByName(details[0]);

                        HopAddition ha = new HopAddition(hop);
                        ha.Quantity = MassCalculator.ParseMassToKg(m[0].Groups[1].Value);
                        for (int i = 1; i < details.Length; i++ )
                        {
                            if (details[i].Length > 3)
                            {
                                ha.TimeOfAddition = Convert.ToInt32(details[i].Replace("min", ""));
                                break;
                            }
                        }
                        totalAlphaAcids += ha.Quantity * ha.Hop.HopAcids.PercentageAlphaAcids;//ignoring utilization atm
                        hopAdditions.list.Add(ha);
                    }
                }
            }

            foreach (var ha in hopAdditions.list) {
                ha.PercentageOfHopBitterness = (ha.Quantity * ha.Hop.HopAcids.PercentageAlphaAcids / totalAlphaAcids) * 100;//ignoring utilization atm
                ha.PercentageOfHopOils = (ha.Quantity / totalAlphaAcids) * 100; //just plain wrong, but hey :)
            }

            return HopDescriber.Describe(hopAdditions);
        }
    }

    internal class HopDescriber
    {
        public static string Describe(HopAdditions hopAdditions)
        {
            bool bittering = false;
            bool flavour = false;
            bool aroma = false;

            string BitternessDescription = "There is a base bitterness with hints of ";
            string FlavourDescription = "With flavours of ";
            string AromaDescription = "Has aromas of ";

            foreach (var hopAddition in hopAdditions.list)
            {
                if (hopAddition.TimeOfAddition >= 45)
                {
                    if (bittering)
                    {
                        BitternessDescription += ", ";
                    }
                    BitternessDescription += String.Join( ", ", hopAddition.Hop.HopFlavours.Select(x => x.flavourDescription));
                    
                    bittering = true;
                }

                if (hopAddition.TimeOfAddition < 45 && hopAddition.TimeOfAddition > 10 )
                {
                      if (bittering)
                    {
                        FlavourDescription += ", ";
                    }
                    FlavourDescription += String.Join( ", ", hopAddition.Hop.HopFlavours.Select(x => x.flavourDescription));
                   
                    flavour = true;
                }

                if (hopAddition.TimeOfAddition <= 10 )
                {  if (aroma)
                    {
                        AromaDescription += ", ";
                    }
                    AromaDescription += String.Join( ", " , hopAddition.Hop.HopFlavours.Select(x => x.flavourDescription));
                    aroma = true;
                }
            }



            string desc = "";
            if (bittering)
            {
                desc += ReplaceLastOccurrence(BitternessDescription, ", ", " and ") + ". ";
            }
            if (flavour)
            {
                desc += ReplaceLastOccurrence(FlavourDescription, ", ", " and ") + ". ";
            }
            if (aroma)
            {
                desc += ReplaceLastOccurrence(AromaDescription, ", ", " and ") + ". ";
            }

            return desc;
        }

        public static string ReplaceLastOccurrence(string source, string find, string replace)
        {
            int place = source.LastIndexOf(find, StringComparison.Ordinal);

            if(place == -1)
                return string.Empty;

            string result = source.Remove(place, find.Length).Insert(place, replace);
            return result;
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

