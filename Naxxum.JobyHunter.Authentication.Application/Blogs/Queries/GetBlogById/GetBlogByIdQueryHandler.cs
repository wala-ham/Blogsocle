using AutoMapper;
using MediatR;
using Naxxum.JobyHunter.Authentication.Application.Blogs.DTOS;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
    {
        private readonly IBlogService _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogByIdQueryHandler(IBlogService blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.Read(request.BlogId);
            return _mapper.Map<BlogVm>(blog);
        }
    }
}
