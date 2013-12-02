using GalaSoft.MvvmLight;
using RestSharp;
using System;
using System.Net;

namespace Stockness.ViewModel.Runtime
{
    public abstract class NetworkViewModel : ViewModelBase
    {
        private IRestClient _client = new RestClient("http://stockness-monster.herokuapp.com/api");
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
            if (!String.IsNullOrEmpty(message))
            {
                resource += "/" + message;
            }
            var request = new RestRequest
            {
                Resource = resource,
                RootElement = "data",
            };
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

        public class Status
        {
            public bool Success { get; set; }
            public string Message { get; set; }
        }
    }
}
