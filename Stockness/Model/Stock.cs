namespace Stockness.Model
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
        public double PriceDelta { get; set; }
        public double OpenPrice { get; set; }
        public double Percentage { get; set; }
    }
}
