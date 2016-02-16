using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class Grapefruit : Flavour
    {
        public Grapefruit(Hops.Overtone overtone) : base(overtone) {}
        public Grapefruit(List<string> adjectives = null) : base(adjectives){}
    }
}