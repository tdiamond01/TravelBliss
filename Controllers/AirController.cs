using Microsoft.AspNetCore.Mvc;

namespace TravelBliss.Controllers
{
    public class AirController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
