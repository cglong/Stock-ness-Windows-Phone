using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Stockness.Core;
using Stockness.ViewModel.Design;

namespace Stockness.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Reset();
            SimpleIoc.Default.Register<NavigationService>();

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            SimpleIoc.Default.Register<IMainViewModel, DesignMainViewModel>();
            SimpleIoc.Default.Register<ISearchViewModel, DesignSearchViewModel>();
            SimpleIoc.Default.Register<IStockViewModel, DesignStockViewModel>();
            SimpleIoc.Default.Register<ITradeViewModel, DesignTradeViewModel>();
            ////}
            ////else
            ////{
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}
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
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}