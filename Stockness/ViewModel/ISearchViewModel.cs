using Stockness.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace Stockness.ViewModel
{
    public interface ISearchViewModel
    {
        IList<Stock> Results { get; }
        Stock SelectedResult { get; set; }
        ICommand SearchCommand { get; }
    }
}
