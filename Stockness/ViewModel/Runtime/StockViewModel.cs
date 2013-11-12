﻿using Stockness.Model;
using System;

namespace Stockness.ViewModel.Runtime
{
    public class StockViewModel : NetworkViewModel, IStockViewModel
    {
        private static string UriFormat = "http://localhost:5000/api/price?symbol={0}";

        public Stock Stock
        {
            set
            {
                Uri uri = new Uri(String.Format(UriFormat, value.Symbol));
                Stock stock = GetObject<Stock>(uri);

                StockSymbol = stock.Symbol;
                StockName = stock.CompanyName;
                CurrPrice = stock.Price;
                PriceChange = stock.PriceChange;
                PercentChange = stock.Percentage;
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
                return "Stockness";
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
    }
}
