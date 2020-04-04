using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Post()
        {
            return "this is Post";
        }

        public string Get()
        {
            return "this is get";
        }

        public string Put()
        {
            return "this is put";
        }

        public string Delete()
        {
            return "this is delete";
        }
    }
}