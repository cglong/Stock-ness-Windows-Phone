using System;

namespace Stockness.Model
{
    public class Transaction
    {
        public Transaction(string symbol, int quantity)
        {
            this.Stock = symbol;
            this.Quantity = quantity;
        }
        public string Stock { get; set; }
        public int Quantity { get; set; }
    }
}
