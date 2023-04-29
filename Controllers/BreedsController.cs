using Microsoft.AspNetCore.Mvc;

namespace PurrfectFeline.Controllers
{
    public class BreedsController:Controller
    {
        public IActionResult Index()
        {
            return View("Breeds");
        }
    }
}
