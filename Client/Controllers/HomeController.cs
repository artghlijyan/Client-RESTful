using Microsoft.AspNetCore.Mvc;
using Client.Interfaces;

namespace ClientInterfaces.Controllers
{
    public class HomeController : Controller
    {
        private IRestService _restClient;

        public HomeController(IRestService restClient)
        {
            _restClient = restClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Get()
        {
            return _restClient.Get().Result.ToString();
        }

        public string Post()
        {
            return _restClient.Post(1).Result.ToString();
        }

        public string Put()
        {
            return _restClient.Put(2).Result.ToString();
        }

        public string Delete()
        {
            return _restClient.Delete(3).Result.ToString();
        }
    }
}