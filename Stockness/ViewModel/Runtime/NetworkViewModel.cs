using GalaSoft.MvvmLight;
using RestSharp;
using System;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private static string BaseUrl = "http://localhost:9442/api";

        protected void GetObject<T>(RestRequest request, Action<IRestResponse<T>> callback) where T : new()
        {
            var client = new RestClient(BaseUrl);
            client.ExecuteAsync<T>(request, callback);
        }
    }
}
