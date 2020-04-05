using Client.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Client.Controllers
{

    public class HomeController : Controller, IRestClient
    {
        static readonly string restUrl = "https://localhost:44357/";
        string requestMessage = string.Empty;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> Post(int number)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);
                var response = client.PostAsJsonAsync("api/rest/post", number).Result;

                if (response.IsSuccessStatusCode)
                {
                    requestMessage = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    requestMessage = "Could nor connect te RESTful Api";
                }
            }

            return requestMessage;
        }

        public async Task<string> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(restUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/rest/get");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (result != null)
                        requestMessage = result;
                }
                else
                {
                    requestMessage = "Could nor connect te RESTful Api";
                }
            }

            return requestMessage;
        }

        public async Task<string> Put()
        {
            return "this is put";
        }

        public async Task<string> Delete()
        {
            return "this is delete";
        }
    }
}