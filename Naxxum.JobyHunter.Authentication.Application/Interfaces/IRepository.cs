using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> Read(int entityId);
        Task<List<TEntity>> ReadAll();
        Task<int> UpdateAsync(int id,TEntity entity);
        Task<int> DeleteAsync(int entityId);
        int SaveChanges();
    }
}
