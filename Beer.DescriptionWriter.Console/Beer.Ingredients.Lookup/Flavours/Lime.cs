namespace Beer.Ingredients.Lookup
{
    internal class Lime : ISpecificFlavour
    {
        public string flavourDescription { get; set; }

        public Lime()
        {
            flavourDescription = "Lime";
        }
    }
}