using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Dto
{
    public class FileCreateUpdateDto
    {
        public Guid? Id { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string FileURL { get; set; }
        public bool IsActive { get; set; }
    }
}
