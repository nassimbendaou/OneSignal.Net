using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal {
    public abstract class BaseService {
        private readonly HttpClient _client;

        protected BaseService() {
            _client = SetupClient();
        }

        private static HttpClient SetupClient() {
            var client = new HttpClient() {
                BaseAddress = new Uri(OneSignalConfiguration.GetBasePath())
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", OneSignalConfiguration.GetApiKey());

            return client;
        }

        private async Task<T> RequestAsync<T>(string uri, string method, BaseOptions options = null) {
            var request = new HttpRequestMessage(new HttpMethod(method), uri) {
                Content = options != null
                    ? new StringContent(options.ToJson(), Encoding.UTF8, "application/json")
                    : new StringContent(string.Empty, Encoding.UTF8, "application/json")
            };

            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK ||
                response.StatusCode == System.Net.HttpStatusCode.Accepted)
                return JsonConvert.DeserializeObject<T>(content);

            if (content.Contains("errors"))
                throw new OneSignalException("There was a problem with the OneSignal request", JsonConvert.DeserializeObject<OneSignalError>(content));

            throw new OneSignalException("There was a problem with the OneSignal request");
        }

        private T Request<T>(string uri, string method, BaseOptions options = null) {
            var request = new HttpRequestMessage(new HttpMethod(method), uri) {
                Content = options != null
                    ? new StringContent(options.ToJson(), Encoding.UTF8, "application/json")
                    : new StringContent(string.Empty, Encoding.UTF8, "application/json")
            };

            var response = _client.SendAsync(request).GetAwaiter().GetResult();
            var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            if (response.StatusCode == System.Net.HttpStatusCode.OK ||
                response.StatusCode == System.Net.HttpStatusCode.Accepted)
                return JsonConvert.DeserializeObject<T>(content);

            if (content.Contains("errors"))
                throw new OneSignalException("There was a problem with the OneSignal request", JsonConvert.DeserializeObject<OneSignalError>(content));

            throw new OneSignalException("There was a problem with the OneSignal request");
        }

        protected async Task<T> GetAsync<T>(string uri, BaseOptions options = null) {
            return await RequestAsync<T>(uri, "GET", options);
        }

        protected T Get<T>(string uri, BaseOptions options = null) {
            return Request<T>(uri, "GET", options);
        }

        protected async Task<T> PostAsync<T>(string uri, BaseOptions options = null) {
            return await RequestAsync<T>(uri, "POST", options);
        }

        protected T Post<T>(string uri, BaseOptions options = null) {
            return Request<T>(uri, "POST", options);
        }

        protected async Task<T> PutAsync<T>(string uri, BaseOptions options = null) {
            return await RequestAsync<T>(uri, "PUT", options);
        }

        protected T Put<T>(string uri, BaseOptions options = null) {
            return Request<T>(uri, "PUT", options);
        }

        protected async Task<T> DeleteAsync<T>(string uri, BaseOptions options = null) {
            return await RequestAsync<T>(uri, "DELETE", options);
        }

        protected T Delete<T>(string uri, BaseOptions options = null) {
            return Request<T>(uri, "DELETE", options);
        }
    }
}
