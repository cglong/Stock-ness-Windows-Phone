using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Stockness.Core;
using Stockness.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private IList<Stock> _results;
        private const string ResultsPropertyName = "Results";
        public IList<Stock> Results
        {
            get
            {
                return _results;
            }
            set
            {
                Set<IList<Stock>>(ResultsPropertyName, ref _results, value);
            }
        }

        public Stock SelectedResult
        {
            get
            {
                return null;
            }
            set
            {
                _navigationService.NavigateTo(ViewModelLocator.StockPageUri(value));
            }
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
            GetAsync<List<Stock>>("search", query, results => Results = results);
        }
    }
}
