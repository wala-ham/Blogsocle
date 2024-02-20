using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using Naxxum.JobyHunter.Authentication.Domain.Entities;
using Naxxum.JobyHunter.Authentication.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Infrastructure.Repositories
{
    public class BlogService : IBlogService
    {
        private readonly IRepository<Blog> _blogRepository;

        public BlogService(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public Task<Blog> AddAsync(Blog entity)
        {
            return _blogRepository.AddAsync(entity);
        }

        public Task<int> DeleteAsync(int entityId)
        {
            return _blogRepository.DeleteAsync(entityId);
        }

        public Task<Blog> Read(int entityId)
        {
            return _blogRepository.Read(entityId);
        }

        public Task<List<Blog>> ReadAll()
        {
            return _blogRepository.ReadAll();
        }

        public int SaveChanges()
        {
            return _blogRepository.SaveChanges();
        }

        public Task<int> UpdateAsync(int id, Blog entity)
        {
            return _blogRepository.UpdateAsync(id, entity);
        }
    }
}
