using Microsoft.AspNetCore.Mvc;

namespace FreelancerProject.Web.Areas.Home
{
    [Area("Home")]
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
