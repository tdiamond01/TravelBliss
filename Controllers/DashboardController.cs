using Microsoft.AspNetCore.Mvc;

namespace TravelBliss.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
