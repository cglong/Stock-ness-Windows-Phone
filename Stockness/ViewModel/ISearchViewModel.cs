using System.Windows.Input;

namespace Stockness.ViewModel
{
    public interface ISearchViewModel
    {
        ICommand SearchCommand { get; }
    }
}
