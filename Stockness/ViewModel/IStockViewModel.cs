namespace Stockness.ViewModel
{
    public interface IStockViewModel
    {
        string StockName { get; }
        string StockSymbol { get; }
        string ApplicationTitle { get; }
        string CurrPrice { get; }
        string PriceChange { get; }
        string PercentChange { get; }
    }
}
