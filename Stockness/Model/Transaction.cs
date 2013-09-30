using System;

namespace Stockness.Model
{
    public class Transaction
    {
        public Stock Stock { get; set; }
        public double Price { get; set; }
        public int Shares { get; set; }
        public DateTime Date { get; set; }
    }
}
