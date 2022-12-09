﻿using System.Net;
using System.Net.Http.Headers;
using HetznerCloudApi.Objects.Universal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HetznerCloudApi
{
    public class ApiCore
    {
        private static string apiToken { get; set; } = string.Empty;
        private static readonly string apiServer = "https://api.hetzner.cloud/v1";

        public static string ApiToken
        {
            get => apiToken;
            set => apiToken = value;
        }

        public static async Task<string> SendGetRequest(string url)
        {
            HttpResponseMessage httpResponseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod("GET"), $"{apiServer}{url}"))
                {
                    httpRequestMessage.Headers.TryAddWithoutValidation("Authorization", $"Bearer {ApiToken}");
                    httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                }
            }

            // IsNullOrEmpty
            string json = await httpResponseMessage.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(json))
            {
                throw new Exception("there has been some error, the API has responded empty.");
            }

            // No OK
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
            {
                JObject result = JObject.Parse(json);
                Error error = JsonConvert.DeserializeObject<Error>($"{result["error"]}") ?? new Error();
                throw new Exception($"{error.message}");
            }

            return json;
        }

        public static async Task<string> SendPostRequest(string url, string content)
        {
            HttpResponseMessage httpResponseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod("POST"), $"{apiServer}{url}"))
                {
                    httpRequestMessage.Headers.TryAddWithoutValidation("Authorization", $"Bearer {ApiToken}");
                    httpRequestMessage.Content = new StringContent(content);
                    httpRequestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                }
            }

            // IsNullOrEmpty
            string json = await httpResponseMessage.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(json))
            {
                throw new Exception("there has been some error, the API has responded empty.");
            }

            // No Created
            if (httpResponseMessage.StatusCode != HttpStatusCode.Created)
            {
                JObject result = JObject.Parse(json);
                Error error = JsonConvert.DeserializeObject<Error>($"{result["error"]}") ?? new Error();
                throw new Exception($"{error.message}");
            }

            return json;
        }

        public static async Task<string> SendPutRequest(string url, string content)
        {
            HttpResponseMessage httpResponseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod("PUT"), $"{apiServer}{url}"))
                {
                    httpRequestMessage.Headers.TryAddWithoutValidation("Authorization", $"Bearer {ApiToken}");
                    httpRequestMessage.Content = new StringContent(content);
                    httpRequestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                }
            }

            // IsNullOrEmpty
            string json = await httpResponseMessage.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(json))
            {
                throw new Exception("there has been some error, the API has responded empty.");
            }

            // No Update
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
            {
                JObject result = JObject.Parse(json);
                Error error = JsonConvert.DeserializeObject<Error>($"{result["error"]}") ?? new Error();
                throw new Exception($"{error.message}");
            }

            return json;
        }

        public static async Task SendDeleteRequest(string url)
        {
            HttpResponseMessage httpResponseMessage;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), $"{apiServer}{url}"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {ApiToken}");
                    httpResponseMessage = await httpClient.SendAsync(request);
                }
            }

            // No Delete
            if (httpResponseMessage.StatusCode != HttpStatusCode.NoContent)
            {
                string json = await httpResponseMessage.Content.ReadAsStringAsync();
                JObject result = JObject.Parse(json);
                Error error = JsonConvert.DeserializeObject<Error>($"{result["error"]}") ?? new Error();
                throw new Exception($"{error.message}");
            }
        }
    }
}