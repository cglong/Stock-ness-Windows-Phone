using GalaSoft.MvvmLight;
using RestSharp;
using System;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private IRestClient _client = new RestClient("http://localhost:9442/api");

        protected void GetAsync<T>(RestRequest request, T message, Action<IRestResponse<T>> callback) where T : new()
        {
            request.AddObject(message);
            _client.ExecuteAsync<T>(request, callback);
        }
    }
}
