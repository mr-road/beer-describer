using System;
using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class DriedFruit : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public List<string> flavourAdjectives { get; set; }
        public IList<Flavour> flavours { get; set; }

        IList<Flavour> ISubGroupFlavour.flavours
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DriedFruit()
        {
            flavourDescription = "Dried Fruits";
            flavours = new List<Flavour> {new Lemon(), new Grapefruit(), new Orange(), new Lime(), new Mandarin()};
        }
    }
}