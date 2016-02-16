using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    public class Flavour : IFlavour
    {
        public string flavourDescription { get { return GetType().Name; } }

        public Flavour(List<string> adjectives = null)
        {
            if (adjectives != null)
            {
                flavourAdjectives = adjectives;
            }
        }

        public Flavour(Hops.Adjective adjective = null)
        {
            if (adjective != null)
            {
                flavourAdjectives = new List<string> { adjective.adjective};
            }
        }

        public List<string> flavourAdjectives { get; set; } = new List<string>();
    }
}