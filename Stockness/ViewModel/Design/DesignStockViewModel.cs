using GalaSoft.MvvmLight;

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
        public string StockName
        {
            get{
                return "Microsoft Corporation";
            }
        }
        public string StockSymbol
        {
            get;
            set;
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