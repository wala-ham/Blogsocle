using AutoMapper;
using MediatR;
using Naxxum.JobyHunter.Authentication.Application.Blogs.DTOS;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using Naxxum.JobyHunter.Authentication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        private readonly IBlogService _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlogCommandHandler(IBlogService blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEnity = new Blog()
            {
                Name = request.Name,
                Description = request.Description,
                Author = request.Author,
                ImageUrl = request.ImageUrl,
            };
            var Result = await _blogRepository.AddAsync(blogEnity);
            return _mapper.Map<BlogVm>(Result);
        }
    }
}
