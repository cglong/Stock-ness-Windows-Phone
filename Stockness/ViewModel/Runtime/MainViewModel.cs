using Stockness.Model;
using System.Collections.Generic;

namespace Stockness.ViewModel.Runtime
{
    public class MainViewModel : NetworkViewModel, IMainViewModel
    {
        public Portfolio User
        {
            set
            {   //Missing userNetChange
                GetAsync<Portfolio>("portfolio", value, portfolio =>
                {
                    UserName = portfolio.Username;
                    UserBalance = portfolio.Value.ToString();
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
        IList<Stock> Stocks {
            get
            {
                return _stocks;
            }
            private set
            {
                Set<IList<Stock>>(StocksPropertyName, ref _stocks, value);
            }
        }

    }
}
