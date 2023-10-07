using Microsoft.AspNetCore.Mvc;

namespace FreelancerProject.Web.Areas.Product
{
    [Area("Product")]
    public class ProductController : Controller
    {
        [HttpGet("/Product")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
