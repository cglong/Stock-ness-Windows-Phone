using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Stockness.Core;
using Stockness.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Stockness.ViewModel.Design
{
    public class DesignMainViewModel : ViewModelBase, IMainViewModel
    {
        private NavigationService _navigationService;

        public DesignMainViewModel(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void LogIn(string username, string password)
        {
        }

        public string UserName
        {
            get
            {
                return "Joon";
            }
        }

        public string UserBalance
        {
            get
            {
                return "$1,333,337";
            }
        }

        public string UserNetChange
        {
            get
            {
                return "8%";
            }
        }

        public string ApplicationTitle
        {
            get
            {
                return "Stockness";
            }
        }

        public IList<Stock> Stocks
        {
            get
            {
                return new List<Stock>
                {
                    new Stock
                    {
                        Symbol = "MSFT",
                        Price = 34.99,
                        PriceChange = 0.83,
                        Percentage = 2.37,
                    },
                    new Stock 
                    {
                        Symbol = "AAPL",
                        Price = 517.79,
                        PriceChange = -0.13,
                        Percentage = -0.02,
                    },
                    new Stock 
                    {
                        Symbol = "GOOG",
                        Price = 1003.27,
                        PriceChange = -1.13,
                        Percentage = -.11,
                    },
                    new Stock 
                    {
                        Symbol = "TWTR",
                        Price = 0.00,
                        PriceChange = 0.00,
                        Percentage = 0.00,
                    },
                    new Stock
                    {
                        Symbol = "YHOO",
                        Price = 34.46,
                        PriceChange = -0.31,
                        Percentage = 0.90,
                    },
                };
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(NavigateToSearchPage);
            }
        }

        private void NavigateToSearchPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.SearchPageUri());
        }

        public Uri SearchButtonIconUri
        {
            get
            {
                return new Uri("/Images/SearchIcon.png", UriKind.Relative);
            }
        }

        public string SearchButtonText
        {
            get
            {
                return "Search";
            }
        }

        public ICommand StockCommand
        {
            get
            {
                return new RelayCommand<Stock>(NavigateToStockPage);
            }
        }

        private void NavigateToStockPage(Stock stock)
        {
            _navigationService.NavigateTo(ViewModelLocator.StockPageUri(stock));
        }
    }
}