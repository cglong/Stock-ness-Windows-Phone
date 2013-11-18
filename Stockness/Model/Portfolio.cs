using System.Collections.Generic;

namespace Stockness.Model
{
    public class Portfolio
    {
        public string Username { get; set; }
        public double Value { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}
