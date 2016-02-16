using System.Collections.Generic;

namespace Beer.Ingredients.Lookup.Flavours
{
    interface IGroupFlavour : IFlavour
    {
        IList<ISubGroupFlavour> SubGroupFlavours { get; set; }
    }
}