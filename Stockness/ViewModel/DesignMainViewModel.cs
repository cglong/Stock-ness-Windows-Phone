using GalaSoft.MvvmLight;

namespace Stockness.ViewModel
{
    public class DesignMainViewModel : ViewModelBase, IMainViewModel
    {
        public DesignMainViewModel()
        {
        }

        public string ApplicationTitle
        {
            get
            {
                return "Stockness";
            }
        }
    }
}