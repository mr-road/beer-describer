using System;
using System.Collections.Generic;
using System.Linq;
using Beer.Ingredients.Lookup.Flavours;

namespace Beer.Ingredients.Lookup
{
    public class Hops
    {
        private static HashSet<Hop> KettleAdditions = new HashSet<Hop>
        {
            new Hop("Amarillo", new HopAcids(9.0m), new List<IFlavour> {new Lime (), new Mandarin()}, Decimal.Zero, "Admiral"),
            new Hop("Citra", new HopAcids(12.0m), new List<IFlavour> {new Grapefruit(), new PassionFruit()}, Decimal.Zero, "Admiral"),
            new Hop("Fuggle", new HopAcids(3.5m), new List<IFlavour> {new Mint(), new Pine()}, Decimal.Zero, "Admiral"),
            //Fruity
            new Hop("Australian Helga", new HopAcids(6.1m,6m,21.5m), new List<IFlavour> {new Floral(), new Herbal()}),
            new Hop("Bravo", new HopAcids(15.5m,4m,31.5m), new List<IFlavour> {new Fruity(new List<string> {"pleasant"}), new Floral()}),
            new Hop("Brewer's Gold", new HopAcids(9m,4m,44  ), new List<IFlavour> {new Spicy(), new BlackCurrant()}),
            new Hop("Bullion", new HopAcids(9.8m,6.4m,3.9m ), new List<IFlavour> {new Zesty(), new BlackCurrant(new List<string> {"strong"})}),
            new Hop("Eroica", new HopAcids(11.1m,4.15m,40  ), new List<IFlavour> {new Fruity(new List<string> {"forward"})}),
            new Hop("Falconer's Flight", new HopAcids(9.75m,4.9m), new List<IFlavour> {new Citrus(new List<string> {"strong"}), new Fruity(new List<string> {"strong"}), new Spicy(new List<string> {"overtone"}), new Earthy(new List<string> {"overtone"})}),
            new Hop("German Brewer's Gold", new HopAcids(7m,3m,44  ), new List<IFlavour> {new BlackCurrant(), new Fruity(), new Spicy()}),
            new Hop("German Hallertau Blanc", new HopAcids(10.5m,5m,24  ), new List<IFlavour> {new Floral(), new Fruity(), new Grapefruit(new Overtone()), new Pineapple(new Overtone()), new LemonGrass(new Overtone())}),
            new Hop("German Opal", new HopAcids(6.5m,4.5m,15  ), new List<IFlavour> {new Floral(), new Fruity(),new Herbal()}),
            new Hop("German Smaragd (Emerald)", new HopAcids(5m,4.5m,15.5m), new List<IFlavour> {new Fruity("Predominant"),new Floral("strong")}),
            new Hop("New Zealand Nelson Sauvin ", new HopAcids(12.5m,7m,24  ), new List<IFlavour> {}),
            new Hop("Australian Galaxy   ", new HopAcids(13.5m,5.95m,37  ), new List<IFlavour> {}),
            new Hop("Cashmere", new HopAcids(8.4m,6.75m,23  ), new List<IFlavour> {}),
            new Hop("Citra", new HopAcids(12m,4m,23  ), new List<IFlavour> {}),
            new Hop("Columbia", new HopAcids(9.15m,4.25m,40  ), new List<IFlavour> {}),
            new Hop("French Triskel", new HopAcids(2.6m,6.7m,21.5m), new List<IFlavour> {}),
            new Hop("Fuggle", new HopAcids(4.75m,1.75m,28.5m), new List<IFlavour> {}),
            new Hop("German Hullmelon", new HopAcids(7.2m,7.6m,27.5m), new List<IFlavour> {}),
            new Hop("Germanmagnum", new HopAcids(13.5m,6m,25  ), new List<IFlavour> {}),
            new Hop("Germanmandarina Bavaria ", new HopAcids(8.5m,5.75m,33  ), new List<IFlavour> {}),
            new Hop("German Perle", new HopAcids(8m,3.75m,30  ), new List<IFlavour> {}),
            new Hop("German Saphir", new HopAcids(3.25m,5.5m,14.5m), new List<IFlavour> {}),
            new Hop("German Select", new HopAcids(4.75m,3.75m,24  ), new List<IFlavour> {}),
            new Hop("UK Bramling Cross", new HopAcids(7m,2.9m,35  ), new List<IFlavour> {}),
            new Hop("Australian Super Pride", new HopAcids(14.4m,7m,27.5m), new List<IFlavour> {}),
            new Hop("Cascade", new HopAcids(5.75m,5.75m,36.5m), new List<IFlavour> {}),
            new Hop("Czech Premiant", new HopAcids(9m,4.75m,20.5m), new List<IFlavour> {}),
            new Hop("Exp - HBC 291", new HopAcids(12.15m,5.6m,21.8m), new List<IFlavour> {}),
            new Hop("German Hersbruker", new HopAcids(3.5m,4.25m,21.5m), new List<IFlavour> {}),
            new Hop("German Spalt", new HopAcids(4m,4m,25.5m), new List<IFlavour> {}),
            new Hop("New Zealandmotueka", new HopAcids(7.5m,5.25m,29  ), new List<IFlavour> {}),
            new Hop("Styrian Savinjski Golding", new HopAcids(4.15m,2.5m,27.5m), new List<IFlavour> {}),
            new Hop("UK Pilgrim", new HopAcids(11m,4.5m,35  ), new List<IFlavour> {}),
        };

        public class Adjective
        {
            public string adjective { get { return GetType().Name; } }
        }

        public class Overtone : Adjective{}

        public static Hop LookupHopByName(string name)
        {
            var hops = KettleAdditions.Where(x => x.Name == name);

            if (!hops.Any()) {
                Console.WriteLine("Missing fermentable: " + name);
                return new Hop("missing");
            }
            return hops.First();
        }
    }
}