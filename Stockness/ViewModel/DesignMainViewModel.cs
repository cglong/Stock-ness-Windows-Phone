using GalaSoft.MvvmLight;

namespace Stockness.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class DesignMainViewModel : ViewModelBase, IMainViewModel
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
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