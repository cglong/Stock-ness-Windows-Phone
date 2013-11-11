namespace Stockness.ViewModel
{
    public interface IStockViewModel
    {
        string StockName { get; }
        string StockSymbol { get; set; }
        string ApplicationTitle { get; }
        double CurrPrice { get; }
        double PriceChange { get; }
        double PercentChange { get; }
    }
}
