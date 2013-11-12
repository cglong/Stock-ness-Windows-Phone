using GalaSoft.MvvmLight;
using Stockness.Model;

namespace Stockness.ViewModel.Design
{
    public class DesignStockViewModel : ViewModelBase, IStockViewModel
    {
       
        public DesignStockViewModel()
        {
        }
        public string ApplicationTitle
        {
            get
            {
                return "Stockness";
            }
        }
        public Stock Stock
        {
            private get;
            set;
        }
        public string StockName
        {
            get{
                return "Microsoft Corporation";
            }
        }
        public string StockSymbol
        {
            get
            {
                return this.Stock.Symbol;
            }
        }
        public double CurrPrice
        {
            get
            {
                return 33.01;
            }
        }
        public double PriceChange
        {
            get
            {
                return 0.06;
            }
        }
        public double PercentChange
        {
            get
            {
                return 0.18;
            }
        }
    }
}