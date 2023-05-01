using Microsoft.AspNetCore.Mvc;

namespace PurrfectFeline.Controllers
{
    public class CatListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
