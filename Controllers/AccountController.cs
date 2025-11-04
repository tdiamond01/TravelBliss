using Microsoft.AspNetCore.Mvc;

namespace TravelBliss.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult GetStarted()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
    }
}
