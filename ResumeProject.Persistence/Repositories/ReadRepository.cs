using Microsoft.EntityFrameworkCore;
using ResumeProject.Application.Repositories;
using ResumeProject.Domain.Entities.Common;
using ResumeProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResumeProject.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ResumeProjectDbContext _context;

        public ReadRepository(ResumeProjectDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>(); 

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query=Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
        {
            return await Table.FirstOrDefaultAsync(x => x.Id==id);
        }

        public async  Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.SingleOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
