using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    interface ISubGroupFlavour : IFlavour
    {
        IList<ISpecificFlavour> flavours { get; set; }
    }
}