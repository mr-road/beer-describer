using System;
using System.Linq;
using Beer.DescriptionWriter.Console.Parsers;

namespace Beer.DescriptionWriter.Console.Calculators
{
    public static class ColourCalculator
    {
         // (EBC = 1.97 * SRM) [Ref: Daniels]
  
        //˚L = EBC / 1.97
        //EBC = ˚L x 1.97

            //http://beersmith.com/blog/2008/04/29/beer-color-understanding-srm-lovibond-and-ebc/
            //http://www.homebrewtalk.com/showthread.php?t=28230

        private static double ColourOfBatchInMCU_Imperial(Fermentables maltBill, decimal volumeInGallons)
        {
            return GetDarkness(maltBill)/Convert.ToDouble(volumeInGallons);
        }

        public static decimal ColourOfBatchInSRM_Imperial(Fermentables maltBill, decimal volumeInGallons)
        {
            return Convert.ToDecimal(1.4922*Math.Pow(ColourOfBatchInMCU_Imperial(maltBill, volumeInGallons), 0.6859));
        }

        private static double GetDarkness(Fermentables maltBill)
        {
            return maltBill.list.Sum(malt => Convert.ToDouble(malt.Quantity*2.2m*malt.ColourLovibond));
        }
    }
}