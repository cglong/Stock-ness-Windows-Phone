using Stockness.Model;

namespace Stockness.ViewModel
{
    public interface ITradeViewModel
    {
        Stock Stock { set; }
        string StockName { get; }
        string StockSymbol { get; }
        string ApplicationTitle { get; }
        double CurrPrice { get; }
        double PriceChange { get; }
        double PercentChange { get; }
    }
}
