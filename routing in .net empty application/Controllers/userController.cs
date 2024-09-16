using Microsoft.AspNetCore.Mvc;

namespace routing_in_.net_empty_application.Controllers
{
    public class userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
