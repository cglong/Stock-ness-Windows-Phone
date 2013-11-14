using GalaSoft.MvvmLight;
using RestSharp;
using System;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private static string BaseUrl = "http://localhost:9442/api";

        protected void GetAsync<T>(RestRequest request, T message, Action<IRestResponse<T>> callback) where T : new()
        {
            var client = new RestClient(BaseUrl);
            request.AddObject(message);
            client.ExecuteAsync<T>(request, callback);
        }
    }
}
