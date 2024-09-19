using Microsoft.AspNetCore.Mvc;
namespace routing_in_.net_empty_application.Controllers
{
    public class HomeController : Controller
    {
        //adding Attributebased Routing to this 
        // to do this we want to add [Route ] Attribute 
        [Route("")]
        // you can define this route attribute many times but with diffrent parameters
        [Route("Home/Index")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }

        // adding the action method which is working with id

        // if any parameter is accepting parameter the that routing is defined in this way

        [Route("Home/Details/{id?}")]
        // we can make this is optional 
        // also we can make this id nullable by adding the ? in front of him
        // like this public  IActionResult Details(int? id)
        public IActionResult Details(int id)
        {

            // also we can assign the default valur in thsi 
            // like this way   return Content(id ?? 1.ToString());
            // this will display 1 by default if the id is null

            // ?? ===> this is nullcollis operator in c#

            return Content(id.ToString());
        }
    }
}