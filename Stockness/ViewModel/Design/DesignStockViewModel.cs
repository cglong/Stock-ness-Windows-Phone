using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Stockness.Core;
using Stockness.Model;
using System;
using System.Windows.Input;

namespace Stockness.ViewModel.Design
{
    public class DesignStockViewModel : ViewModelBase, IStockViewModel
    {
        private NavigationService _navigationService;

         public DesignStockViewModel(NavigationService navigationService)
        {
            _navigationService = navigationService;
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

        public ICommand TradeCommand
        {
            get
            {
                return new RelayCommand<Stock>(NavigateToTradePage);
            }
        }

        private void NavigateToTradePage(Stock stock)
        {
            _navigationService.NavigateTo(ViewModelLocator.TradePageUri(stock));
        }

        public Uri TradeButtonIconUri
        {
            get
            {
                return new Uri("/Images/TradeIcon.png", UriKind.Relative);
            }
        }

        public string TradeButtonText
        {
            get
            {
                return "Trade";
            }
        }

    }
}