using GalaSoft.MvvmLight.Command;
using Stockness.Core;
using Stockness.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Stockness.ViewModel.Runtime
{
    public class MainViewModel : NetworkViewModel, IMainViewModel
    {
        private NavigationService _navigationService;

        public MainViewModel(NavigationService navigationService)
        {
            _navigationService = navigationService;
            PostAsync("login", new Login { username = "heisenberg", password = "BCpassword" });
        }

        public Account User
        {
            set
            {   //Missing userNetChange
                GetAsync<Portfolio>("portfolio", value, portfolio =>
                {
                    UserName = portfolio.Username;
                    UserBalance = portfolio.Value.ToString();
                    Stocks = portfolio.Stocks;
                });
            }
        }

        public string ApplicationTitle {
            get
            {
                return "Stockness";
            }
        }

        private string _userName;
        private const string UserNamePropertyName = "UserName";
        public string UserName {
            get
            {
                return _userName;
            }
            private set
            {
                Set<string>(UserNamePropertyName, ref _userName, value);
            }
        }

        private string _userBalance;
        private const string UserBalancePropertyName = "UserBalance";
        public string UserBalance {
            get
            {
                return _userBalance;
            }
            private set
            {
                Set<string>(UserBalancePropertyName, ref _userBalance, value);
            }
        }

        private string _userNetChange;
        private const string UserNetChangePropertyName = "UserNetChange";
        public string UserNetChange {
            get
            {
                return _userNetChange;
            }
            private set
            {
                Set<string>(UserNetChangePropertyName, ref _userNetChange, value);
            }
        }

        private IList<Stock> _stocks;
        private const string StocksPropertyName = "Stocks";
        public IList<Stock> Stocks {
            get
            {
                return _stocks;
            }
            private set
            {
                Set<IList<Stock>>(StocksPropertyName, ref _stocks, value);
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

        private class Login
        {
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}
