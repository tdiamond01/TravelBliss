using Microsoft.AspNetCore.Mvc;

namespace TravelBliss.Controllers
{
    public class GroupsController : Controller
    {
        public IActionResult Details(int id)
        {
            // In a real application, you would fetch the group details from a database
            // For now, we'll pass the ID to the view
            ViewBag.GroupId = id;
            return View();
        }
    }
}
