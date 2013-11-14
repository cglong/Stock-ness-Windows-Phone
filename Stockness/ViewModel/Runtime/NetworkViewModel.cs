using GalaSoft.MvvmLight;
using RestSharp;
using System;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private IRestClient _client = new RestClient("http://localhost:5000/api");

        protected void GetAsync<T>(string resource, object message, Action<IRestResponse<T>> callback) where T : new()
        {
            var request = new RestRequest(resource);
            request.AddObject(message);
            SendAsync<T>(request, callback);
        }

        protected void PostAsync<T>(string resource, object message, Action<IRestResponse<T>> callback) where T : new()
        {
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(message);
            SendAsync<T>(request, callback);
        }

        private void SendAsync<T>(IRestRequest request, Action<IRestResponse<T>> callback) where T : new()
        {
            _client.ExecuteAsync<T>(request, callback);
        }
    }
}
