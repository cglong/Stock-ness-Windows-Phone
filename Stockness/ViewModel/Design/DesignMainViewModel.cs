using GalaSoft.MvvmLight;
using Stockness.Core;
using Stockness.Model;
using System.Collections.Generic;

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
    }
}