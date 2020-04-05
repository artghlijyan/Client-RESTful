using Client.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Client.Impl
{
    public class RestClientImpl : IRestClient
    {
        static readonly string restUrl = "https://localhost:44357/";
        static string requestMessage = null;
        static HttpClient client;

        async Task<string> IRestClient.Post(int id)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);

                HttpResponseMessage response = await client.PostAsJsonAsync("api/rest/post/id", id);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result != null)
                    {
                        requestMessage = result;
                    }
                    else
                    {
                        return "Could not connect te RESTful Api";
                    }
                }
            }

            return requestMessage;
        }

        async Task<string> IRestClient.Get()
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);
                HttpResponseMessage response = await client.GetAsync("api/rest/get/");

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result != null)
                    {
                        requestMessage = result;
                    }
                    else
                    {
                        return "Could not connect te RESTful Api";
                    }
                }
            }

            return requestMessage;
        }

        async Task<string> IRestClient.Put(int id)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);
                HttpResponseMessage response = await client.PutAsJsonAsync("api/rest/put/id", id);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result != null)
                    {
                        requestMessage = result;
                    }
                    else
                    {
                        return "Could not connect te RESTful Api";
                    }
                }
            }

            return requestMessage;
        }

        async Task<string> IRestClient.Delete(int id)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);
                HttpResponseMessage response = await client.DeleteAsync($"api/rest/delete/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result != null)
                    {
                        requestMessage = result;
                    }
                    else
                    {
                        return "Could not connect te RESTful Api";
                    }
                }

                return requestMessage;
            }
        }
    }
}
