using FreelancerProject.Dto.Product;
using FreelancerProject.Services.DbContexts;
using FreelancerProject.Services.Extensions;
using FreelancerProject.Services.FileSystem;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerProject.Web.Areas.Product
{
    [Area("Product")]
    public class ProductController : Controller
    {
        private readonly ProductDbContext _dbContext;
        private readonly IFileSystemService _fileSystemService;
        public ProductController(ProductDbContext dbContext, IFileSystemService fileSystemService)
        {
            _dbContext = dbContext;
            _fileSystemService = fileSystemService;
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
                var data = productQuery.Select(x => new ProductCreateUpdateDto
                {
                    Id = x.Id,
                    ImageFile = null,
                    Image = x.Image,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                });//.Skip(skipCount).Take(maxCount).ToList();

                // Return Data And Counter
                return Json(new
                {
                    totalCount = totalCount,
                    data = data
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

        [HttpGet("/Product/CreateProduct")]
        public async Task<IActionResult> CreateProduct()
        {
            ProductCreateUpdateDto createUpdateDto = new ProductCreateUpdateDto();
            return View(createUpdateDto);
        }
        [HttpPost("/Product/CreateProduct")]
        public async Task<IActionResult> CreateProduct(ProductCreateUpdateDto createUpdateDto)
        {
            try
            {
                string errorMessage = "";
                if (createUpdateDto.Name.IsNullOrWhiteSpace())
                    errorMessage = "Product Name is required.";
                else if (createUpdateDto.Description.IsNullOrWhiteSpace())
                    errorMessage = "Product Description is required.";
                else if (createUpdateDto.Price <=0.0f)
                    errorMessage = "Product Price is required.";

                if(errorMessage != "")
                {
                    TempData["Error"] = errorMessage;
                    return View(createUpdateDto);
                }
                var fileInfo = await _fileSystemService.UploadFile(createUpdateDto.ImageFile);

                var fileURL = fileInfo?.FileURL;
                var data = _dbContext.Products.Add(new Models.Product.ProductModel
                {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    CreationTime = DateTime.Now,
                    Description = createUpdateDto.Description,
                    Name = createUpdateDto.Name,
                    Price = createUpdateDto.Price,
                    Image = fileURL,
                });

                createUpdateDto.Id = data.Entity.Id;

                TempData["Success"] = "Product Successfully Added.";
                return Redirect("/");

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
