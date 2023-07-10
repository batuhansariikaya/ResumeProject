using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ResumeProject.Application.Repositories;
using ResumeProject.Domain.Entities.Common;
using ResumeProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ResumeProjectDbContext _context;

        public WriteRepository(ResumeProjectDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public Task<bool> AddRangeAsync(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            entity.isActive = false;
            return entityEntry.State == EntityState.Modified;
        }

        public Task<bool> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
