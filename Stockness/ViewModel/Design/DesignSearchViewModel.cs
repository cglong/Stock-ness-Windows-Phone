using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Stockness.Core;
using Stockness.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Stockness.ViewModel.Design
{
    public class DesignSearchViewModel : ViewModelBase, ISearchViewModel
    {
        private NavigationService _navigationService;

        public DesignSearchViewModel()
        {
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
            Stock s = new Stock { Symbol = query, };
            _navigationService.NavigateTo(ViewModelLocator.StockPageUri(s));
        }
    }
}