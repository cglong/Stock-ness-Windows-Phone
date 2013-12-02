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
        double UserBalance { get; }
        double UserNetChange { get; }

        IList<Stock> Stocks { get; }

        ICommand SearchCommand { get; }
        Uri SearchButtonIconUri { get; }
        string SearchButtonText { get; }

        ICommand StockCommand { get; }
    }
}
