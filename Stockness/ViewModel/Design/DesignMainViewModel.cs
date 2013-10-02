using GalaSoft.MvvmLight;

namespace Stockness.ViewModel.Design
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