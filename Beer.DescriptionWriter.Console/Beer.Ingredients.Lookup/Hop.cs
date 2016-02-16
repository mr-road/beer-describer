using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    public class Hop
    {
        public string Name { get; set; }

        public decimal Storage { get; set; } //(% alpha acids remaining after 6 months storage at 20° C) 60 - 65%

        public string PossibleSubstitutions { get; private set; }

        public IList<IFlavour> HopFlavours { get; private set; }

        public  HopAcids HopAcids  { get; private set; }
        public  HopOils HopOils  { get; private set; }

        public Hop(string name)
        {
             Name = name;
        }

        public Hop(string name, HopAcids hopAcids, IList<IFlavour> hopFlavours, decimal storage = 0.00m, string possibleSubstitutions = "", HopOils hopOils = null)
        {
            Name = name;
            Storage = storage;
            PossibleSubstitutions = possibleSubstitutions;
            HopAcids = hopAcids;
            HopOils = hopOils;
            HopFlavours = hopFlavours;
        }
    }
}