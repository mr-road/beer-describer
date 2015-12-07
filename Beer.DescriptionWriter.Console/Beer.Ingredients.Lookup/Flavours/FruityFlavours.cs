using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    class FruityFlavours : IGroupFlavour
    {
        public string flavourDescription { get; set; }
        public IList<ISubGroupFlavour> SubGroupFlavours { get; set; }

        public FruityFlavours()
        {
            flavourDescription = "Fruity";
            SubGroupFlavours = new List<ISubGroupFlavour> {new Citrus(), new Berry(), new PipFruit(), new TropicalFruit(), new DriedFruit()};
        }
    }
}