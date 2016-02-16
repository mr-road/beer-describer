using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    interface ISubGroupFlavour : IFlavour
    {
        IList<Flavour> flavours { get; set; }
    }
}