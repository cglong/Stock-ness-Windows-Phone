using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Stockness.Core;
using Stockness.Model;
using Stockness.ViewModel.Design;
using Stockness.ViewModel.Runtime;
using System;

namespace Stockness.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Reset();
            SimpleIoc.Default.Register<NavigationService>();

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IMainViewModel, DesignMainViewModel>();
                SimpleIoc.Default.Register<ISearchViewModel, DesignSearchViewModel>();
                SimpleIoc.Default.Register<IStockViewModel, DesignStockViewModel>();
                SimpleIoc.Default.Register<ITradeViewModel, DesignTradeViewModel>();
            }
            else
            {
                SimpleIoc.Default.Register<IMainViewModel, MainViewModel>();
                SimpleIoc.Default.Register<ISearchViewModel, SearchViewModel>();
                SimpleIoc.Default.Register<IStockViewModel, StockViewModel>();
                SimpleIoc.Default.Register<ITradeViewModel, TradeViewModel>();
            }
        }

        public IMainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IMainViewModel>();
            }
        }

        public ISearchViewModel Search
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ISearchViewModel>();
            }
        }

        public IStockViewModel Stock
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IStockViewModel>();
            }
        }

        public ITradeViewModel Trade
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ITradeViewModel>();
            }
        }

        public static Uri SearchPageUri()
        {
            return new Uri("/View/SearchPage.xaml", UriKind.Relative);
        }

        public static Uri StockPageUri(Stock stock)
        {
            string uri = String.Format("/View/StockPage.xaml?symbol={0}", stock.Symbol);
            return new Uri(uri, UriKind.Relative);
        }

        public static Uri TradePageUri(Stock stock)
        {
            string uri = String.Format("/View/TradePage.xaml?symbol={0}", stock.Symbol);
            return new Uri(uri, UriKind.Relative);
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}