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

        public IList<Position> Positions
        {
            get
            {
                return new List<Position>
                {
                    new Position
                    {
                        Stock = new Stock
                        {
                            Symbol = "MSFT",
                        },
                    },
                    new Position 
                    {
                        Stock = new Stock
                        {
                            Symbol = "AAPL",
                        }
                    },
                    new Position 
                    {
                        Stock = new Stock
                        {
                            Symbol = "GOOG",
                        }
                    },
                    new Position 
                    {
                        Stock = new Stock
                        {
                            Symbol = "TWTR",
                        }
                    },
                    new Position
                    {
                        Stock = new Stock
                        {
                            Symbol = "YHOO",
                        }
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

        public ICommand TradeCommand
        {
            get
            {
                return new RelayCommand(NavigateToTradePage);
            }
        }

        private void NavigateToTradePage()
        {
            _navigationService.NavigateTo(ViewModelLocator.TradePageUri());
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