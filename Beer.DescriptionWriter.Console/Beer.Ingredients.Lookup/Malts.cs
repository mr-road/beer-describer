using System;
using System.Collections.Generic;
using System.Linq;

namespace Beer.Ingredients.Lookup
{
    public class Malts
    {
        //http://dieseldrafts.com/spreadsheet/frameset.html?Formulas.html
        //https://studentofbeer.wordpress.com/tag/brewhouse-calculations/
        //http://homebrewmanual.com/home-brewing-calculations/

        public static Fermentable LookupFermentableByName(string name)
        {
            var fermentables = Fermentables.Where(x => x.Name == name);
            if (!fermentables.Any())
            {
                Console.WriteLine("Missing fermentable: " + name);
                return new Fermentable("missing");
            }
            return fermentables.First();
        }

        private static readonly List<Fermentable> Fermentables = new List<Fermentable>
        {
            new Fermentable("Acid Malt","Germany","Grain",3 ,true,1.027m ,10.0m),
            new Fermentable("Amber Dry Extract","US","Dry Extract",13 ,false,1.044m ,100.0m),
            new Fermentable("Amber Liquid Extract","US","Extract",13 ,false,1.036m ,100.0m),
            new Fermentable("Amber Malt","United Kingdom","Grain",22 ,true,1.035m ,20.0m),
            new Fermentable("Aromatic Malt,","Belgium",",Grain",26 ,true,1.036m ,10.0m),
            new Fermentable("Barley Hulls","US","Adjunct",0 ,false,1.000m ,5.0m),
            new Fermentable("Barley, Flaked","US","Grain",2 ,true,1.032m ,20.0m),
            new Fermentable("Barley, Raw","US","Grain",2 ,true,1.028m ,15.0m),
            new Fermentable("Barley, Torrefied","US","Grain",2 ,true,1.036m ,40.0m),
            new Fermentable("Biscuit Malt,","Belgium",",Grain",23 ,false,1.036m ,10.0m),
            new Fermentable("Black (Patent) Malt","US","Grain",500 ,false,1.025m ,10.0m),
            new Fermentable("Black Barley (Stout)","US","Grain",500 ,false,1.025m ,10.0m),
            new Fermentable("Brown Malt","United Kingdom","Grain",65 ,true,1.032m ,10.0m),
            new Fermentable("Brown Sugar, Dark","US","Sugar",50 ,false,1.046m ,10.0m),
            new Fermentable("Brown Sugar, Light","US","Sugar",8 ,false,1.046m ,10.0m),
            new Fermentable("Brumalt","Germany","Grain",23 ,true,1.033m ,10.0m),
            new Fermentable("Candi Sugar, Amber,","Belgium","Sugar",75 ,false,1.036m ,20.0m),
            new Fermentable("Candi Sugar, Clear,","Belgium","Sugar",1 ,false,1.036m ,20.0m),
            new Fermentable("Candi Sugar, Dark,","Belgium","Sugar",275 ,false,1.036m ,20.0m),
            new Fermentable("Cane (Beet) Sugar","US","Sugar",0 ,false,1.046m ,7.0m),
            new Fermentable("Cara-Pils/Dextrine","US","Grain",2 ,false,1.033m ,20.0m),
            new Fermentable("Caraamber","US","Grain",30 ,false,1.035m ,20.0m),
            new Fermentable("Carafoam","US","Grain",2 ,false,1.033m ,20.0m),
            new Fermentable("Caramel/Crystal Malt - 10L","US","Grain",10 ,false,1.035m ,20.0m),
            new Fermentable("Caramel/Crystal Malt - 20L","US","Grain",20 ,false,1.035m ,20.0m),
            new Fermentable("Caramel/Crystal Malt - 30L","US","Grain",30 ,false,1.035m ,20.0m),
            new Fermentable("Caramel/Crystal Malt - 40L","US","Grain",40 ,false,1.034m ,20.0m),
            new Fermentable("Caramel/Crystal Malt - 60L","US","Grain",60 ,false,1.034m ,20.0m),
            new Fermentable("Caramel/Crystal Malt - 80L","US","Grain",80 ,false,1.034m ,20.0m),
            new Fermentable("Caramel/Crystal Malt -120L","US","Grain",120 ,false,1.033m ,20.0m),
            new Fermentable("Caramunich Malt,","Belgium",",Grain",56 ,false,1.033m ,10.0m),
            new Fermentable("Carared","US","Grain",20 ,false,1.035m ,20.0m),
            new Fermentable("Caravienne Malt,","Belgium",",Grain",22 ,false,1.034m ,10.0m),
            new Fermentable("Chocolate Malt","US","Grain",350 ,false,1.028m ,10.0m),
            new Fermentable("Chocolate Malt","United Kingdom","Grain",450 ,false,1.034m ,10.0m),
            new Fermentable("Corn Sugar (Dextrose)","US","Sugar",0 ,false,1.046m ,5.0m),
            new Fermentable("Corn Syrup","US","Sugar",1 ,false,1.036m ,10.0m),
            new Fermentable("Corn, Flaked","US","Grain",1 ,true,1.037m ,40.0m),
            new Fermentable("Dark Dry Extract","US","Dry Extract",18 ,false,1.044m ,100.0m),
            new Fermentable("Dark Liquid Extract","US","Extract",18 ,false,1.036m ,100.0m),
            new Fermentable("Dememera Sugar","United Kingdom","Sugar",2 ,false,1.046m ,10.0m),
            new Fermentable("Extra Light Dry Extract","US","Dry Extract",3 ,false,1.044m ,100.0m),
            new Fermentable("Grits","US","Adjunct",1 ,false,1.037m ,10.0m),
            new Fermentable("Honey","US","Extract",1 ,false,1.035m ,100.0m),
            new Fermentable("Invert Sugar","United Kingdom","Sugar",0 ,false,1.046m ,10.0m),
            new Fermentable("Light Dry Extract","US","Dry Extract",8 ,false,1.044m ,100.0m),
            new Fermentable("Maple Syrup","US","Sugar",35 ,false,1.030m ,10.0m),
            new Fermentable("Melafalseiden Malt","Germany","Grain",20 ,true,1.037m ,15.0m),
            new Fermentable("Mild Malt","United Kingdom","Grain",4 ,true,1.037m ,100.0m),
            new Fermentable("Milk Sugar (Lactose)","US","Sugar",0 ,false,1.035m ,10.0m),
            new Fermentable("Molasses","US","Sugar",80 ,false,1.036m ,5.0m),
            new Fermentable("Munich Malt","Germany","Grain",9 ,true,1.037m ,80.0m),
            new Fermentable("Munich Malt - 10L","US","Grain",10 ,true,1.035m ,80.0m),
            new Fermentable("Munich Malt - 20L","US","Grain",20 ,true,1.035m ,80.0m),
            new Fermentable("Oats, Flaked","US","Grain",1 ,true,1.037m ,30.0m),
            new Fermentable("Oats, Malted","US","Grain",1 ,true,1.037m ,10.0m),
            new Fermentable("Pale Liquid Extract","US","Extract",8 ,false,1.036m ,100.0m),
            new Fermentable("Pale Malt (2 Row) Bel","Belgium",",Grain",3 ,true,1.037m ,100.0m),
            new Fermentable("Pale Malt (2 Row) UK","United Kingdom","Grain",3 ,true,1.036m ,100.0m),
            new Fermentable("Maris Otter","United Kingdom","Grain",3 ,true,1.036m ,100.0m),
            new Fermentable("Pale Malt (2 Row) US","US","Grain",2 ,true,1.036m ,100.0m),
            new Fermentable("Pale Malt (6 Row) US","US","Grain",2 ,true,1.035m ,100.0m),
            new Fermentable("Peat Smoked Malt","United Kingdom","Grain",3 ,true,1.034m ,20.0m),
            new Fermentable("Pilsner (2 Row) Bel","Belgium",",Grain",2 ,true,1.036m ,100.0m),
            new Fermentable("Pilsner (2 Row) Ger","Germany","Grain",2 ,true,1.037m ,100.0m),
            new Fermentable("Pilsner (2 Row) UK","United Kingdom","Grain",1 ,true,1.036m ,100.0m),
            new Fermentable("Pilsner Liquid Extract","US","Extract",4 ,false,1.036m ,100.0m),
            new Fermentable("Rice Extract Syrup","US","Extract",7 ,false,1.032m ,15.0m),
            new Fermentable("Rice Hulls","US","Adjunct",0 ,false,1.000m ,5.0m),
            new Fermentable("Rice, Flaked","US","Grain",1 ,true,1.032m ,25.0m),
            new Fermentable("Roasted Barley","US","Grain",300 ,false,1.025m ,10.0m),
            new Fermentable("Rye Malt","US","Grain",5 ,true,1.029m ,15.0m),
            new Fermentable("Rye, Flaked","US","Grain",2 ,true,1.036m ,10.0m),
            new Fermentable("Smoked Malt","Germany","Grain",9 ,true,1.037m ,100.0m),
            new Fermentable("Special B Malt,","Belgium",",Grain",180 ,true,1.030m ,10.0m),
            new Fermentable("Special Roast","US","Grain",50 ,true,1.033m ,10.0m),
            new Fermentable("Sugar, Table (Sucrose)","US","Sugar",1 ,false,1.046m ,10.0m),
            new Fermentable("Toasted Malt","United Kingdom","Grain",27 ,true,1.033m ,10.0m),
            new Fermentable("Turbinado","United Kingdom","Sugar",10 ,false,1.044m ,10.0m),
            new Fermentable("Victory Malt","US","Grain",25 ,true,1.034m ,15.0m),
            new Fermentable("Vienna Malt","Germany","Grain",4 ,true,1.036m ,90.0m),
            new Fermentable("Wheat Dry Extract","US","Dry Extract",8 ,false,1.044m ,100.0m),
            new Fermentable("Wheat Liquid Extract","US","Extract",8 ,false,1.036m ,100.0m),
            new Fermentable("Wheat Malt, Bel","Belgium",",Grain",2 ,true,1.037m ,60.0m),
            new Fermentable("Wheat Malt, Dark","Germany","Grain",9 ,true,1.039m ,20.0m),
            new Fermentable("Wheat Malt, Ger","Germany","Grain",2 ,true,1.039m ,60.0m),
            new Fermentable("Wheat, Flaked","US","Grain",2 ,true,1.035m ,40.0m),
            new Fermentable("Wheat, Roasted","Germany","Grain",425 ,true,1.025m ,10.0m),
            new Fermentable("Wheat, Torrified","US","Grain",2 ,true,1.036m ,40.0m),
            new Fermentable("White Wheat Malt","US","Grain",2 ,true,1.040m ,60.0m),
        };  
    }
}