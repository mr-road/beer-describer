using System;
using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    public class Hops
    {
        private HashSet<Hop> _hops = new HashSet<Hop>
        {
            new Hop("Amarillo", new HopAcids(9.0m), new List<IFlavour> {new Lime(), new Mandarin()}, Decimal.Zero, "Admiral")
        };

        public static Hop LookupHopByName(string value)
        {
            throw new NotImplementedException();
        }
    }
}