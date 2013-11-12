using GalaSoft.MvvmLight;
using System;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        protected T GetObject<T>(Uri uri)
        {
            return default(T);
        }
    }
}
