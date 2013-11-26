using GalaSoft.MvvmLight;
using System.Windows.Input;

namespace Stockness.ViewModel.Design
{
    public class DesignSearchViewModel : ViewModelBase, ISearchViewModel
    {
        public DesignSearchViewModel()
        {
        }

        public ICommand SearchCommand
        {
            get
            {
                return null;
            }
        }
    }
}