namespace Beer.Ingredients.Lookup
{
    public class HopAcids
    {
        public decimal PercentageAlphaAcids { get; set; }  // eg 9.5 - 11.5%
        public decimal PercentageBetaAcids { get; set; }   // eg  3.5 - 4.5%
        public decimal PercentageCohumulone { get; set; }  // eg  (% of alpha acids) 29 - 30%

        public HopAcids(decimal percentageAlphaAcids, decimal percentageBetaAcids = 0.0m, decimal percentageCohumulone = 0.0m)
        {
            PercentageAlphaAcids = percentageAlphaAcids;
            PercentageBetaAcids = percentageBetaAcids;
            PercentageCohumulone = percentageCohumulone;
        }
    }
}