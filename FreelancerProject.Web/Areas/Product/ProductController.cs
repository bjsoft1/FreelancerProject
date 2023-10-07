using FreelancerProject.Services.DbContexts;
using FreelancerProject.Services.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerProject.Web.Areas.Product
{
    [Area("Product")]
    public class ProductController : Controller
    {
        private readonly ProductDbContext _dbContext;
        public ProductController(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("/Product")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Product/GetProductPaginationListing")]
        public async Task<IActionResult> GetProductPaginationListing(int skipCount = 0, int maxCount = 10, string SearchKeyword = "")
        {
            try
            {
                // Create Product Query For Make similary data comes in Counter and Data List.
                var productQuery = _dbContext.Products.Where(x => !x.IsDeleted && x.IsActive);

                //Basic Filter
                if (!SearchKeyword.IsNullOrWhiteSpace())
                    productQuery = productQuery.Where(x => x.Name.Contains(SearchKeyword.Trim()) || x.Description.Contains(SearchKeyword.Trim()));

                //TODO: Sorting, Order By

                //TODO: Create Pagination Parameter DTO

                // Get All Counter
                int totalCount = productQuery.Count();
                
                // Return Data And Counter
                return Json(new
                {
                    totalCount = totalCount,
                    data = productQuery.Select(x => new
                    {
                        Image = x.Image,
                        Name = x.Name,
                        Description = x.Description,
                        Price = x.Price,
                    }).Skip(skipCount).Take(maxCount).ToList()
                });
            }
            catch (Exception ex)
            {
                // When Comes Error then return Error Page 

                // Error Message after redirect page.
                TempData["Error"] = ex.Message;


                //TODO: Setup This page and Gloabal Error Handling.
                return Redirect("Error");
            }
        }
    }
}
