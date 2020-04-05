using Client.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Client.Impl
{
    public class RestClientImpl : IRestClient
    {
        readonly string restUrl = "https://localhost:44357/";
        string requestMessage = null;
        HttpClient client;

        async Task<string> IRestClient.Post(int number)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);
                HttpResponseMessage response = client.PostAsJsonAsync("api/rest/post", number).Result;

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
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/rest/get");

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
                HttpResponseMessage response = client.PutAsJsonAsync("api/rest/put", id).Result;

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
                client.BaseAddress = new Uri("http://localhost:1565/");
                HttpResponseMessage response = client.DeleteAsync("api/rest/delete").Result;

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
    }
}
