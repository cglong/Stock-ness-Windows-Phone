using Stockness.Model;
using System.Web.Http;

namespace Stockness.Web.Controllers
{
    public class PriceController : ApiController
    {
        public Stock Get(string symbol)
        {
            return new Stock
            {
                Symbol = symbol,
            };
        }
    }
}
