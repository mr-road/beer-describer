using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    internal class DriedFruit : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public IList<ISpecificFlavour> flavours { get; set; }

        public DriedFruit()
        {
            flavourDescription = "Dried Fruits";
            flavours = new List<ISpecificFlavour> {new Lemon(), new Grapefruit(), new Orange(), new Lime(), new Mandarin()};
        }
    }
}