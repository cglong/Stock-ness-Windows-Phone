using Stockness.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace Stockness.ViewModel
{
    public interface ISearchViewModel
    {
        IList<Stock> Results { get; }
        ICommand SearchCommand { get; }
    }
}
