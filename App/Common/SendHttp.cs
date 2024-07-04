using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace App
{
    public class SendHttp
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> SendGetAsync(string url, Dictionary<string, string> headers = null)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            // Add headers to the request
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    httpRequestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            HttpResponseMessage response = await client.SendAsync(httpRequestMessage);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> SendPostAsync(string url, HttpContent content, Dictionary<string, string> headers = null)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content,
            };

            // Add headers to the request
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    httpRequestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            HttpResponseMessage response = await client.SendAsync(httpRequestMessage);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
