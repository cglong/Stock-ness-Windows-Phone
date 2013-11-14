using GalaSoft.MvvmLight;
using RestSharp;
using System;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private IRestClient _client = new RestClient("http://localhost:9442/api");

        protected void GetAsync<T>(IRestRequest request, T message, Action<IRestResponse<T>> callback) where T : new()
        {
            request.AddObject(message);
            SendAsync<T>(request, callback);
        }

        protected void PostAsync<T>(IRestRequest request, T message, Action<IRestResponse<T>> callback) where T : new()
        {
            request.Method = Method.POST;
            request.AddBody(message);
            SendAsync<T>(request, callback);
        }

        private void SendAsync<T>(IRestRequest request, Action<IRestResponse<T>> callback) where T : new()
        {
            _client.ExecuteAsync<T>(request, callback);
        }
    }
}
