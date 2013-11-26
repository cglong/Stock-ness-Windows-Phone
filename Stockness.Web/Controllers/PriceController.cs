using Stockness.Model;
using System.Web.Http;

namespace Stockness.Web.Controllers
{
    public class PriceController : ApiController
    {
        public Stock Get(string id)
        {
            switch(id){
                case "MSFT":
                    return new Stock
                    {
                        Symbol = id,
                        CompanyName = "Microsoft Corporation",
                        Price = 37.36,
                        PriceChange = -0.23,
                        Percentage = -0.61,
                    };
                    
                case "AAPL":
                    return new Stock
                    {
                        Symbol = id,
                        CompanyName = "Apple Inc.",
                        Price = 520.01,
                        PriceChange = 0.96,
                        Percentage = 0.19,
                    };

                case "GOOG":
                    return new Stock
                    {
                        Symbol = id,
                        CompanyName = "Google Inc.",
                        Price = 1011.78,
                        PriceChange = 1.19,
                        Percentage = 0.12,
                    };

                case "TWTR":
                    return new Stock
                    {
                        Symbol = id,
                        CompanyName = "Twitter Inc.",
                        Price = 41.90,
                        PriceChange = -1.00,
                        Percentage = -2.33,
                    };

                case "YHOO":
                    return new Stock
                    {
                        Symbol = id,
                        CompanyName = "Yahoo! Inc.",
                        Price = 34.07,
                        PriceChange = 0.26,
                        Percentage = 0.75,
                    };

                case "FB":
                    return new Stock
                    {
                        Symbol = id,
                        CompanyName = "Facebook Inc.",
                        Price = 46.60,
                        PriceChange = 0.40,
                        Percentage = 0.88,
                    };

                default:
                    return new Stock
                    {
                        Symbol = id,
                        //CompanyName = "Data Unknown",
                        Price = 0,
                        PriceChange = 0,
                        Percentage = 0,
                    };
                    
            }
        }
    }
}
