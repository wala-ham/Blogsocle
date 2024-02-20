using Naxxum.JobyHunter.Authentication.Application.Common.Mappings;
using Naxxum.JobyHunter.Authentication.Domain.Entities;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.DTOS
{
    public class BlogVm : IMapFrom<Blog>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }

    }
}
