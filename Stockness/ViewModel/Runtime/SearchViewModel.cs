using GalaSoft.MvvmLight.Command;
using Stockness.Core;
using System.Windows.Input;

namespace Stockness.ViewModel.Runtime
{
    public class SearchViewModel : NetworkViewModel, ISearchViewModel
    {
        private NavigationService _navigationService;

        public SearchViewModel(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand<string>(Search);
            }
        }

        private void Search(string query)
        {
        }
    }
}
