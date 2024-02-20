using AutoMapper;
using MediatR;
using Naxxum.JobyHunter.Authentication.Application.Blogs.DTOS;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
    {
        private readonly IBlogService _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogQueryHandler(IBlogService blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.ReadAll();
            //var blogList =  blogs.Select(x => new BlogVm 
            //  { Author = x.Author, Name = x.Name, 
            //      Description = x.Description , Id = x.Id }).ToList();

            var blogList = _mapper.Map<List<BlogVm>>(blogs);
            return blogList;
        }
    }
}
