using GalaSoft.MvvmLight;
using RestSharp;
using System;
using System.Net;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private IRestClient _client = new RestClient("http://localhost:5000/api");
        private static CookieContainer _cookieContainer = new CookieContainer();

        protected NetworkViewModel()
        {
            _client.CookieContainer = _cookieContainer;
        }

        protected void GetAsync<T>(string resource, object message, Action<T> callback) where T : new()
        {
            var request = new RestRequest(resource);
            request.AddObject(message);
            SendAsync<T>(request, callback);
        }

        protected void PostAsync(string resource, object message)
        {
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(message);
            request.RootElement = "status";
            SendAsync<Status>(request, o => { });
        }

        private void SendAsync<T>(IRestRequest request, Action<T> callback) where T : new()
        {
            _client.ExecuteAsync<T>(request, response => callback(response.Data));
        }

        private class Status
        {
            public bool Success { get; set; }
            public string Message { get; set; }
        }
    }
}
