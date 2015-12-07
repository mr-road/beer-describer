using System.Collections.Generic;
using System.Text;
using Beer.Ingredients.Lookup;

namespace Beer.Ingredients.Lookup
{
    internal class Orange : ISpecificFlavour
    {
        public string flavourDescription { get; set; }
    }

    internal class Grapefruit : ISpecificFlavour
    {
        public string flavourDescription { get; set; }
    }

    internal class Lemon : ISpecificFlavour
    {
        public string flavourDescription { get; set; }
    }

    internal class TropicalFruit : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public IList<ISpecificFlavour> flavours { get; set; }

        public TropicalFruit()
        {
            
        }
    }

    internal class PipFruit : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public IList<ISpecificFlavour> flavours { get; set; }
    }

    internal class Berry : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public IList<ISpecificFlavour> flavours { get; set; }
    }

    class Citrus : ISubGroupFlavour
    {
        public string flavourDescription { get; set; }
        public IList<ISpecificFlavour> flavours { get; set; }
    }
}
