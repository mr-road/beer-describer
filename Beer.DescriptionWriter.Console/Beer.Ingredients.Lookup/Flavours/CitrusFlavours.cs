using System.Collections.Generic;
using Beer.Ingredients.Lookup.Flavours;

namespace Beer.Ingredients.Lookup
{
    class CitrusFlavours : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public List<string> flavourAdjectives { get; set; }
        public IList<Flavour> flavours { get; set; }
    }
}