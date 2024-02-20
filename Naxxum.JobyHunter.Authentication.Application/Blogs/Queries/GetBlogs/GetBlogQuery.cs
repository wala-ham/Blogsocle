using MediatR;
using Naxxum.JobyHunter.Authentication.Application.Blogs.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQuery : IRequest<List<BlogVm>>
    {
    }
}
