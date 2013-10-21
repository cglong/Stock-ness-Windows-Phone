using GalaSoft.MvvmLight;

namespace Stockness.ViewModel.Design
{
    public class DesignTradeViewModel : ViewModelBase, ITradeViewModel
    {
        public DesignTradeViewModel()
        {
        }

        public string ApplicationTitle
        {
            get
            {
                return "Trade";
            }
        }
    }
}