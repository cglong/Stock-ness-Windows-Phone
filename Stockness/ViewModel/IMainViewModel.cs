using Stockness.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Stockness.ViewModel
{
    public interface IMainViewModel
    {
        string ApplicationTitle { get; }
        string UserName { get; }
        string UserBalance { get; }
        string UserNetChange { get; }

        IList<Position> Positions { get; }

        ICommand SearchCommand { get; }
        Uri SearchButtonIconUri { get; }
        string SearchButtonText { get; }

        ICommand StockCommand { get; }

        ICommand TradeCommand { get; }
        Uri TradeButtonIconUri { get; }
        string TradeButtonText { get; }
    }
}
