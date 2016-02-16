using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class Fruity : Flavour
    {
        public Fruity(string adjective): this(new List<string> {adjective}){}

        public Fruity(List<string> adjectives = null) : base(adjectives) {}
    }
}