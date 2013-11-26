using System;
using Stockness.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Stockness.Web.Controllers
{
    public class PortfolioController : ApiController
    {
        // GET api/portfolio
        public Portfolio Get()
        {
            return new Portfolio
                    {
                        Username = "5",
                        Value = 1333777.53f,
                        Stocks = new List<Stock>
                        {
                            new Stock
                            {
                                Symbol = "MSFT",
                                CompanyName = "Microsoft Corporation",
                                Price = 37.36,
                                PriceChange = -0.23,
                                Percentage = -0.61,
                            },
                            new Stock
                            {
                                Symbol = "AAPL",
                                CompanyName = "Apple Inc.",
                                Price = 520.01,
                                PriceChange = 0.96,
                                Percentage = 0.19,
                            },
                            new Stock
                            {
                                Symbol = "GOOG",
                                CompanyName = "Google Inc.",
                                Price = 1011.78,
                                PriceChange = 1.19,
                                Percentage = 0.12,
                            },
                            new Stock
                            {
                                Symbol = "TWTR",
                                CompanyName = "Twitter Inc.",
                                Price = 41.90,
                                PriceChange = -1.00,
                                Percentage = -2.33,
                            },
                            new Stock
                            {
                                Symbol = "YHOO",
                                CompanyName = "Yahoo! Inc.",
                                Price = 34.07,
                                PriceChange = 0.26,
                                Percentage = 0.75,
                            },
                            new Stock
                            {
                                Symbol = "FB",
                                CompanyName = "Facebook Inc.",
                                Price = 46.60,
                                PriceChange = 0.40,
                                Percentage = 0.88,
                            }

                        },

                    };
        }

        // GET api/portfolio/5
        public Portfolio Get(int id)
        {
            switch (id)
            {
                case 5:
                    return new Portfolio
                    {
                        Username = "5",
                        Value = 1333777.53f,
                        Stocks = new List<Stock>
                        {
                            new Stock
                            {
                                Symbol = "MSFT",
                                CompanyName = "Microsoft Corporation",
                                Price = 37.36,
                                PriceChange = -0.23,
                                Percentage = -0.61,
                            },
                            new Stock
                            {
                                Symbol = "AAPL",
                                CompanyName = "Apple Inc.",
                                Price = 520.01,
                                PriceChange = 0.96,
                                Percentage = 0.19,
                            },
                            new Stock
                            {
                                Symbol = "GOOG",
                                CompanyName = "Google Inc.",
                                Price = 1011.78,
                                PriceChange = 1.19,
                                Percentage = 0.12,
                            },
                            new Stock
                            {
                                Symbol = "TWTR",
                                CompanyName = "Twitter Inc.",
                                Price = 41.90,
                                PriceChange = -1.00,
                                Percentage = -2.33,
                            },
                            new Stock
                            {
                                Symbol = "YHOO",
                                CompanyName = "Yahoo! Inc.",
                                Price = 34.07,
                                PriceChange = 0.26,
                                Percentage = 0.75,
                            },
                            new Stock
                            {
                                Symbol = "FB",
                                CompanyName = "Facebook Inc.",
                                Price = 46.60,
                                PriceChange = 0.40,
                                Percentage = 0.88,
                            }

                        },

                    };

                default:
                    return new Portfolio
                    {
                        Username = "-1",
                        Value = -1,
                        Stocks = new List<Stock>
                        {
                            new Stock
                            {
                                Symbol = "NULL",
                                CompanyName = "NULL CORPORATION",
                                Price = -1,
                                PriceChange = -0.1,
                                Percentage = -0.1,
                            }

                        },

                    };
            }
        }

        // POST api/portfolio
        public void Post([FromBody]string value)
        {
        }

        // PUT api/portfolio/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/portfolio/5
        public void Delete(int id)
        {
        }
    }
}
