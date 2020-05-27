using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client.Interfaces.Impl
{
    public class RestServiceImpl : IRestService
    {
        static readonly string restUrl = "https://localhost:44357/";
        static string requestMessage = null;
        static HttpClient client;

        async Task<string> IRestService.Post(int id)
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

        async Task<string> IRestService.Get()
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

        async Task<string> IRestService.Put(int id)
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

        async Task<string> IRestService.Delete(int id)
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
