using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class Floral : Flavour
    {
        public Floral(string adjective): this(new List<string> {adjective}){}
        public Floral(List<string> adjectives = null) : base(adjectives){}
    }
}