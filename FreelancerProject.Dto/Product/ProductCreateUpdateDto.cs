using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Dto.Product
{
    public class ProductCreateUpdateDto
    {
        public Guid? Id { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
