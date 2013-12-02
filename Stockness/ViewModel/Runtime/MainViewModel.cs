using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
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
            Messenger.Default.Register<LoginMessage>(this, LogIn);
            Messenger.Default.Register<UpdateMessage>(this, LoadPortfolio);
        }

        private void LogIn(LoginMessage message)
        {
            var login = new Login
            {
                Username = message.Username,
                Password = message.Password,
            };
            PostAsync("login", login, () => LoadPortfolio());
        }

        private void LoadPortfolio(UpdateMessage message = null)
        {
            GetAsync<Portfolio>("portfolio", portfolio =>
            {
                UserName = portfolio.Username;
                UserBalance = portfolio.Value;
                Stocks = portfolio.Stocks;
            });
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

        private double _userBalance;
        private const string UserBalancePropertyName = "UserBalance";
        public double UserBalance {
            get
            {
                return _userBalance;
            }
            private set
            {
                Set<double>(UserBalancePropertyName, ref _userBalance, value);
            }
        }

        private double _userNetChange;
        private const string UserNetChangePropertyName = "UserNetChange";
        public double UserNetChange {
            get
            {
                return _userNetChange;
            }
            private set
            {
                Set<double>(UserNetChangePropertyName, ref _userNetChange, value);
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

        private class Login
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
