using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    interface IGroupFlavour : IFlavour
    {
        IList<ISubGroupFlavour> SubGroupFlavours { get; set; }
    }
}