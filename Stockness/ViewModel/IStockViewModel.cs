using Stockness.Model;
using System;
using System.Windows.Input;

namespace Stockness.ViewModel
{
    public interface IStockViewModel
    {
        Stock Stock { set; }
        string StockName { get; }
        string StockSymbol { get; }
        string ApplicationTitle { get; }
        double CurrPrice { get; }
        double PriceChange { get; }
        double PercentChange { get; }

        ICommand TradeCommand { get; }
        Uri TradeButtonIconUri { get; }
        string TradeButtonText { get; }

    }
}
