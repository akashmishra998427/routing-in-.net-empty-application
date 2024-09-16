using Microsoft.AspNetCore.Mvc;
namespace routing_in_.net_empty_application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        // adding the action method which is working with id
        public IActionResult Details(int id)
        {
            return Content(id.ToString());
        }
    }
}