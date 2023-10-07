
namespace FreelancerProject.Models.Product
{
    public class ProductModel : BaseModels.BaseModel<Guid>
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
