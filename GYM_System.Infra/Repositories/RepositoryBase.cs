using GYM_System.Domain.Interfaces.Repositories;
using GYM_System.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GYM_System.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DataContext _db;
        protected DbSet<TEntity> _dbSet;

        public RepositoryBase(DataContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            await _dbSet.AddAsync(obj);
            await _db.SaveChangesAsync();

            return obj;
        }

        public async Task<List<TEntity>> AddRangeAsync(List<TEntity> obj)
        {
            await _dbSet.AddRangeAsync(obj);
            await _db.SaveChangesAsync();

            return obj;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task RemoveAsync(TEntity obj)
        {
             _dbSet.Remove(obj);

             await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            _dbSet.Update(obj);
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(true);
        }
    }
}