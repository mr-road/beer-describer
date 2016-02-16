using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    class FruityFlavours : IGroupFlavour
    {
        public string flavourDescription { get; set; }
        public List<string> flavourAdjectives { get; set; }
        public IList<ISubGroupFlavour> SubGroupFlavours { get; set; }

        public FruityFlavours()
        {
            flavourDescription = "Fruity";
            SubGroupFlavours = new List<ISubGroupFlavour> {new CitrusFlavours(), new BerryFlavours(), new PipFruit(), new TropicalFruit(), new DriedFruit()};
        }
    }
}