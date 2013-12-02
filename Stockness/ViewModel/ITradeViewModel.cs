using Stockness.Model;
using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Stockness.ViewModel
{
    public interface ITradeViewModel
    {
        Stock Stock { set; }
        string Quantity { set; get; }
        ICommand SellCommand { get; }
        ICommand BuyCommand { get; }
        string StockName { get; }
        string StockSymbol { get; }
        string ApplicationTitle { get; }
        double CurrPrice { get; }
        double PriceChange { get; }
        double PercentChange { get; }
    }
}
