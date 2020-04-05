using Microsoft.AspNetCore.Mvc;
using Client.Interfaces;
using Client.Impl;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        IRestClient restClient = new RestClientImpl();

        public IActionResult Index()
        {
            return View();
        }

        public string Post()
        {
            return restClient.Post(1).Result.ToString();
        }

        public string Get()
        {
            return restClient.Get().Result.ToString();
        }

        public string Put()
        {
            return restClient.Put(2).Result.ToString();
        }

        public string Delete()
        {
            return restClient.Delete(3).Result.ToString();
        }
    }
}