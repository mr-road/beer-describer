using System.Collections.Generic;

namespace Beer.Ingredients.Lookup
{
    public interface IFlavour
    {
        string flavourDescription { get;  }
        List<string> flavourAdjectives { get; set; }
    }
}