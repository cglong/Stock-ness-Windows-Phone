using System.Collections.Generic;

namespace Stockness.Model
{
    public class Member
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Portfolio Portfolio { get; set; }
        public IList<Transaction> Transactions { get; set; }
    }
}
