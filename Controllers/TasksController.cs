using Microsoft.AspNetCore.Mvc;

namespace TravelBliss.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
