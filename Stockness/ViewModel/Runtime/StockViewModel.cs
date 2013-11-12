﻿using Stockness.Model;
using System;

namespace Stockness.ViewModel.Runtime
{
    public class StockViewModel : NetworkViewModel, IStockViewModel
    {
        private Stock _stock;
        private static string UriFormat = "http://localhost:5000/api/price?symbol={0}";

        public string StockSymbol
        {
            get
            {
                return _stock.Symbol;
            }
            set
            {
                Uri uri = new Uri(String.Format(UriFormat, value));
                _stock = GetObject<Stock>(uri);
            }
        }

        public string StockName
        {
            get
            {
                return _stock.CompanyName;
            }
        }

        public string ApplicationTitle
        {
            get
            {
                return "Stockness";
            }
        }

        public double CurrPrice
        {
            get
            {
                return _stock.Price;
            }
        }

        public double PriceChange
        {
            get
            {
                return _stock.PriceChange;
            }
        }

        public double PercentChange
        {
            get
            {
                return _stock.Percentage;
            }
        }
    }
}
