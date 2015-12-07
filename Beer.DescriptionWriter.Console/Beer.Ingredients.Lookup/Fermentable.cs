namespace Beer.Ingredients.Lookup
{
    public class Fermentable
    {
        public readonly decimal PotentialSg;
        public readonly decimal MaxPercentageInBatch;
        public string Name { get; set; }
        public decimal ColourSRM { get; set; }
        public decimal ColourLovibond { get; set; }
        public decimal Quantity { get; set; }

        public Fermentable(string name)
        {
            Name = name;
            PercentageOfMash = 0m;
            Quantity = 0m;
            ColourSRM = 0m;
        }

        public Fermentable(string name, string countryOfOrigin, string fermentableType , int SRM, bool mustMash, decimal potentialSG, decimal maxPercentageInBatch)
        {
            PotentialSg = potentialSG;
            MaxPercentageInBatch = maxPercentageInBatch;
            Name = name;
            PercentageOfMash = 0m;
            Quantity = 0m;
            ColourSRM = SRM;
            ColourLovibond = (SRM + 0.6m) / 1.35m;//http://www.homebrewtalk.com/showthread.php?t=28230
        }

        public override string ToString()
        {
            return $"{Name}, {Quantity}kg, {PercentageOfMash}%, {ColourSRM} EBC";
        }

        public decimal PercentageOfMash { get; set; }
    }
}