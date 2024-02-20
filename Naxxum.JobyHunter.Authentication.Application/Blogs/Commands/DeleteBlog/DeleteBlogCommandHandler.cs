using MediatR;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
    {
        private readonly IBlogService _blogRepository;

        public DeleteBlogCommandHandler(IBlogService blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            return await _blogRepository.DeleteAsync(request.Id);
        }
    }
}
