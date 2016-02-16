using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    internal class Mandarin : Flavour
    {
        public Mandarin(Hops.Overtone overtone) : base(overtone) {}
        public Mandarin(List<string> adjectives = null) : base(adjectives){}
    }
}