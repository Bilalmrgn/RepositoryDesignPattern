using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Entity => _context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public Task Update(T entity)
        {
            Entity.Update(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            Entity.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await Entity.FindAsync(id);
            if (entity != null)
                Entity.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public IQueryable<T> GetAllById(int id)
        {
            return Entity.Where(e => EF.Property<int>(e, "Id") == id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            return Entity.Where(method);
        }
    }
}
