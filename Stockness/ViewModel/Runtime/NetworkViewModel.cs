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

        protected void GetAsync<T>(string resource, Action<T> callback) where T : new()
        {
            GetAsync<T>(resource, null, callback);
        }

        protected void GetAsync<T>(string resource, string message, Action<T> callback) where T : new()
        {
            resource += message != null ? "/" + message : "";
            var request = new RestRequest(resource);
            SendAsync<T>(request, callback);
        }

        protected void PostAsync(string resource, object message)
        {
            PostAsync(resource, message, () => { });
        }

        protected void PostAsync(string resource, object message, Action callback)
        {
            var request = new RestRequest
            {
                Resource = resource,
                Method = Method.POST,
                RequestFormat = DataFormat.Json,
                RootElement = "status",
            };
            request.AddBody(message);
            SendAsync<Status>(request, o => callback());
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
