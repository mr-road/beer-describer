using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Beer.DescriptionWriter.Console.Parsers;

namespace Beer.DescriptionWriter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 ||
            args.Contains("-h") || args.Contains("--help"))
            {
                PrintHelp();
                Environment.Exit(0);
            }

            List<string> recipe = new List<string>();
            StreamReader reader = File.OpenText(args[0]);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                recipe.Add(line);
            }

            var rp = new RecipeParser(recipe);
            rp.PrintDescription();

            System.Console.WriteLine(@"Press any key to exit");
            System.Console.ReadKey();
            Environment.Exit(0);
        }

        private static void PrintHelp()
        {
            System.Console.WriteLine(@"Please provide a path to your recipe file");

            System.Console.WriteLine(
 @"Please provide your recipe file in the following format:
    <Name>
    <Batch Size><Volume Unit(l/gal/galUS)>
    <Mash Temp (K/C/F)>
    <amount (Kg|kg|g)||(lb|oz)> [tab] <Malt Name><optional  
    <amount ....> [tab] <Hop Name> [tab]
    <yeast name>
    <fermentation temp (K/C/F)>

PS: All measures are SI (l/kg/k) if no units provided, and if using puny US gallons (galUS) is required not (gal)

eg

BIG BAD BEER
20l
66C
3kg     Maris Otter
20g     Citra   60min
Safale s04
290.15
            ");
        }
    }
}
