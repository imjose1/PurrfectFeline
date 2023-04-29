using Microsoft.AspNetCore.Mvc;

namespace PurrfectFeline.Controllers
{
    public class CatsListController : Controller
    {
        public IActionResult Index()
        {
            return View("CatsList");
        }
    }
}
