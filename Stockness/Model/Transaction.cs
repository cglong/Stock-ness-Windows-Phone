using System;

namespace Stockness.Model
{
    public class Transaction
    {
        public Transaction(Stock stock, int quantity)
        {
            this.Stock = stock;
            this.Quantity = quantity;
        }
        public Stock Stock { get; set; }
        public int Quantity { get; set; }
    }
}
