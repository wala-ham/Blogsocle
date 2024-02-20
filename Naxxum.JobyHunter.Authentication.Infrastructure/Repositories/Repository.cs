using Naxxum.JobyHunter.Authentication.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;

namespace Naxxum.JobyHunter.Authentication.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entity;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> Read(int entityId)
        {
            return await _entity.FindAsync(entityId);
        }

        public async Task<List<TEntity>> ReadAll()
        {
            return await _entity.ToListAsync();
        }

        public async Task<int> UpdateAsync(int id, TEntity entity)
        {
            var existingEntity = await _entity.FindAsync(id);
            if (existingEntity == null)
            {
                // Handle the case where the entity with the specified id is not found
                return 0;
            }

            // Update the existing entity with the new values
            _context.Entry(existingEntity).CurrentValues.SetValues(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int entityId)
        {
            var entityToDelete = await _entity.FindAsync(entityId);
            if (entityToDelete == null)
            {
                // Handle the case where the entity with the specified id is not found
                return 0;
            }

            _entity.Remove(entityToDelete);

            return await _context.SaveChangesAsync();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
