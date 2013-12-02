using Stockness.Model;
using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Stockness.ViewModel.Runtime
{
    public class TradeViewModel : NetworkViewModel, ITradeViewModel
    {
        private Stock _stock;
        private const string StockPropertyName = "Stock";
        public Stock Stock
        {
            set
            {
                GetAsync<Stock>("price", value.Symbol, stock =>
                {
                    StockSymbol = stock.Symbol;
                    StockName = stock.CompanyName;
                    CurrPrice = stock.Price;
                    PriceChange = stock.PriceChange;
                    PercentChange = stock.Percentage;
                    LastPrice = stock.LastPrice;
                    _stock = stock;
                });
            }
        }

        private string _stockSymbol;
        private const string StockSymbolPropertyName = "StockSymbol";
        public string StockSymbol
        {
            get
            {
                return _stockSymbol;
            }
            private set
            {
                Set<string>(StockSymbolPropertyName, ref _stockSymbol, value);
            }
        }

        private string _stockName;
        private const string StockNamePropertyName = "StockName";
        public string StockName
        {
            get
            {
                return _stockName;
            }
            private set
            {
                Set<string>(StockNamePropertyName, ref _stockName, value);
            }
        }

        public string ApplicationTitle
        {
            get
            {
                return "Trade";
            }
        }

        private double _currPrice;
        private const string CurrPricePropertyName = "CurrPrice";
        public double CurrPrice
        {
            get
            {
                return _currPrice;
            }
            private set
            {
                Set<double>(CurrPricePropertyName, ref _currPrice, value);
            }
        }

        private double _priceChange;
        private const string PriceChangePropertyName = "PriceChange";
        public double PriceChange
        {
            get
            {
                return _priceChange;
            }
            private set
            {
                Set<double>(PriceChangePropertyName, ref _priceChange, value);
            }
        }

        private double _percentChange;
        private const string PercentChangePropertyName = "PercentChange";
        public double PercentChange
        {
            get
            {
                return _percentChange;
            }
            private set
            {
                Set<double>(PercentChangePropertyName, ref _percentChange, value);
            }
        }

        private double _lastPrice;
        private const string LastPricePropertyName = "LastPrice";
        public double LastPrice
        {
            get
            {
                return _lastPrice;
            }
            private set
            {
                Set<double>(LastPricePropertyName, ref _lastPrice, value);
            }
        }

        public string Quantity
        {
            get;
            set;
        }

        public string Action
        {
            get;
            set;
        }


        public ICommand TradeCommand
        {
            get
            {
                return new RelayCommand<Stock>(Trade);
            }
        }

        private void Trade(Stock stock)
        {
            PostAsync(this.Action,
                      new Transaction(stock, int.Parse(this.Quantity))
            );
        }
    }
}
