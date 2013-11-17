using Stockness.Model;
using System.Web.Http;

namespace Stockness.Web.Controllers
{
    public class PriceController : ApiController
    {
        public Stock Get(string symbol)
        {
            switch(symbol){
                case "MSFT":
                    return new Stock
                    {
                        Symbol = symbol,
                        CompanyName = "Microsoft Corporation",
                        Price = 37.36,
                        PriceChange = -0.23,
                        Percentage = -0.61,
                        LastPrice = 37.38,
                    };
                    
                case "AAPL":
                    return new Stock
                    {
                        Symbol = symbol,
                        CompanyName = "Apple Inc.",
                        Price = 520.01,
                        PriceChange = 0.96,
                        Percentage = 0.19,
                        LastPrice = 517.67,
                    };

                case "GOOG":
                    return new Stock
                    {
                        Symbol = symbol,
                        CompanyName = "Google Inc.",
                        Price = 1011.78,
                        PriceChange = 1.19,
                        Percentage = 0.12,
                        LastPrice = 1007.70,
                    };

                case "TWTR":
                    return new Stock
                    {
                        Symbol = symbol,
                        CompanyName = "Twitter Inc.",
                        Price = 41.90,
                        PriceChange = -1.00,
                        Percentage = -2.33,
                        LastPrice = 43.66,
                    };

                case "YHOO":
                    return new Stock
                    {
                        Symbol = symbol,
                        CompanyName = "Yahoo! Inc.",
                        Price = 34.07,
                        PriceChange = 0.26,
                        Percentage = 0.75,
                        LastPrice = 34.00,
                    };

                case "FB":
                    return new Stock
                    {
                        Symbol = symbol,
                        CompanyName = "Facebook Inc.",
                        Price = 46.60,
                        PriceChange = 0.40,
                        Percentage = 0.88,
                        LastPrice = 46.00,
                    };

                default:
                    return new Stock
                    {
                        Symbol = symbol,
                        //CompanyName = "Data Unknown",
                        Price = 0,
                        PriceChange = 0,
                        Percentage = 0,
                        LastPrice = 0,
                    };
                    
            }
        }
    }
}
