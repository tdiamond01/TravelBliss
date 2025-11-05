using Microsoft.AspNetCore.Mvc;

namespace TravelBliss.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
