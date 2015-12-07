namespace Beer.Ingredients.Lookup
{
    public class HopOils
    {
        private decimal TotalOils  { get; set; }         //(Mls. per 100 grams dried hops) 1.5 - 2.5
        private decimal Myrcene { get; set; }            // eg  (as % of total oils) 45 - 55%
        private decimal Caryophyllene { get; set; }      // eg  (as % of total oils) 5.0 - 8.0%
        private decimal Humulene { get; set; }           // eg  (as % of total oils) 10 - 18%
        private decimal Farnesene { get; set; }          // eg  (as % of total oils) < 1.0%

        public HopOils(decimal totalOils, decimal myrcene, decimal caryophyllene, decimal humulene, decimal farnesene)
        {
            TotalOils = totalOils;
            Myrcene = myrcene;
            Caryophyllene = caryophyllene;
            Humulene = humulene;
            Farnesene = farnesene;
        }
    }
}