using MailSchedular.Application.Interfaces.Repositories;
using MailSchedular.Domain.Common;
using MailSchedular.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly SchedularDbContext _dbContext;
        public DbSet<T> Table => _dbContext.Set<T>();
        public GenericRepository(SchedularDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        => Table.AsQueryable();

        public async Task<T> GetByIdAsync(int id)
        => await Table.AsQueryable().FirstOrDefaultAsync(x => x.Id == id);

        public bool Remove(T entity)
        {
            EntityEntry entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveByIdAsync(int id)
        {
            T entity = await Table.FirstOrDefaultAsync(x => id == x.Id);
            return Remove(entity);
        }
        public bool Update(T model)
        {
            EntityEntry entity = Table.Update(model);
            return entity.State == EntityState.Modified;
        }
        public async Task<int> SaveChangesAsync()
            => await _dbContext.SaveChangesAsync();
    }
}
