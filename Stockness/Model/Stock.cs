namespace Stockness.Model
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public string Market { get; set; }
        public double Price { get; set; }
        public double PriceChange { get; set; }
        public double Percentage { get; set; }
        public double LastPrice
        {
            get
            {
                return Price - PriceChange;
            }
        }
    }
}
