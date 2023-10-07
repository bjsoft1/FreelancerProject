using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Services.Extensions
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return (value == null || value.Trim() == string.Empty);
        }
    }
}
