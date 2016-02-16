using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class LemonGrass : Flavour
    {
        public LemonGrass(Hops.Overtone overtone) : base(overtone) {}
        public LemonGrass(List<string> adjectives = null) : base(adjectives){}
    }
}