using System.Configuration;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Infraestructure.Infra_integration.Base
{
    public abstract class BaseIntegration
    {
        public string BaseAddress { private get; set; }

        private int Timeout
        {
            get => Convert.ToInt32(ConfigurationManager.AppSettings["HTTP_CONNECTION_TIMEOUT_MINUTES"] ?? "2");
        }


        protected async Task<T?> GetAsync<T>(string path, params object[] filters)
            where T : class =>
            await GetAsync<T>(new GetArgs
            {
                Path = path,
                Filters = filters,
            });

        protected async Task<T?> PostAsync<T>(string path, object bodyContent, params object[] filters)
            where T : class =>
            await PostAsync<T>(new PostArgs
            {
                Path = path,
                BodyContent = bodyContent,
                Filters = filters
            });

        protected async Task<T?> PostAsync<T>(PostArgs args) where T : class
        {
            if (args is null)
            {
                throw new ArgumentNullException("args");
            }

            if (string.IsNullOrWhiteSpace(args.Path))
            {
                throw new ArgumentException("Invalid argument", "Path");
            }

            string path = args.Path;
            IDictionary<string, IEnumerable<string>> headers = args.Headers;

            if (args.Filters != null && args.Filters.Any())
            {
                path += $"/{string.Join("/", args.Filters)}";
            }

            using (var client = httpClient)
            {
                setDefaultHeaders(client, headers);

                string uri = $"{BaseAddress}/{path}";

                var payload = new StringContent(
                    JsonSerializer.Serialize(args.BodyContent),
                    Encoding.UTF8,
                    "application/json");

                using HttpResponseMessage response = await client.PostAsync(uri, payload);

                response.EnsureSuccessStatusCode();

                return await JsonSerializer.DeserializeAsync<T?>(await response.Content.ReadAsStreamAsync());
            }

        }

        protected async Task<T?> GetAsync<T>(GetArgs args) where T : class
        {
            if (args is null)
            {
                throw new ArgumentNullException("args");
            }

            if (string.IsNullOrWhiteSpace(args.Path))
            {
                throw new ArgumentException("Invalid argument", "Path");
            }

            string path = args.Path;
            IDictionary<string, IEnumerable<string>> headers = args.Headers;

            if (args.Filters != null && args.Filters.Any())
            {
                path += $"/{string.Join("/", args.Filters)}";
            }

            using (var client = httpClient)
            {
                setDefaultHeaders(client, headers);

                string uri = $"{BaseAddress}/{path}";

                using HttpResponseMessage response = await client.GetAsync(uri);

                response.EnsureSuccessStatusCode();

                return await JsonSerializer.DeserializeAsync<T?>(await response.Content.ReadAsStreamAsync());
            }

        }

        private void setDefaultHeaders(HttpClient client, IDictionary<string, IEnumerable<string>> headers)
        {
            if (headers is null)
                return;

            foreach (var h in headers)
                client.DefaultRequestHeaders.Add(h.Key, h.Value);
        }

        private HttpClient httpClient
        {
            get
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (Timeout > 0)
                {
                    client.Timeout = TimeSpan.FromMinutes(Timeout);
                }

                return client;
            }
        }
    }
}
