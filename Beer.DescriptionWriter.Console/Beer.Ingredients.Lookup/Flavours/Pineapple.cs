using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class Pineapple : Flavour
    {
        public Pineapple(Hops.Overtone overtone) : base(overtone) {}
        public Pineapple(List<string> adjectives = null) : base(adjectives){}
    }
}