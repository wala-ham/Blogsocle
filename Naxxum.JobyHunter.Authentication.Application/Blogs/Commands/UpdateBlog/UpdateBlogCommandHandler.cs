using MediatR;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using Naxxum.JobyHunter.Authentication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
    {
        private readonly IBlogService _blogRepository;

        public UpdateBlogCommandHandler(IBlogService blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var UdateblogEntity = new Blog()
            {
                Id = request.Id,
                Author = request.Author,
                Description = request.Description,
                Name = request.Name,
                ImageUrl = request.ImageUrl,
            };

            return await _blogRepository.UpdateAsync(request.Id, UdateblogEntity);
        }
    }
}
