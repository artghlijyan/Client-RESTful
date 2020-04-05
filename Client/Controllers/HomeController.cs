using Microsoft.AspNetCore.Mvc;
using Client.Interfaces;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        IRestClient restClient;

        public IActionResult Index()
        {
            return View();
        }

        public string Post(int id)
        {
            return restClient.Post(id).ToString();
        }

        public string Get()
        {
            return restClient.Get().ToString();
        }

        public string Put(int id)
        {
            return restClient.Put(id).ToString();
        }

        public string Delete(int id)
        {
            return restClient.Delete(id).ToString();
        }
    }
}