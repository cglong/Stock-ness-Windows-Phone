using System.Collections.Generic;

namespace Stockness.Model
{
    public class Portfolio
    {
        public string Username { get; set; }
        public double Value { get; set; }
        public IList<Stock> Stocks { get; set; }
    }
}
