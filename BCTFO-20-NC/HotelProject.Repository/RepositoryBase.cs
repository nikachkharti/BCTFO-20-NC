using HotelProject.Data;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelProject.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, string includePropeties = null)
        {
            IQueryable<T> query = _dbSet;

            if (!string.IsNullOrWhiteSpace(includePropeties))
            {
                foreach (var includeProperty in includePropeties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            var entities = await query
                .Where(filter)
                .ToListAsync();

            return entities;
        }

        public async Task<List<T>> GetAllAsync(string includePropeties = null)
        {
            IQueryable<T> query = _dbSet;

            if (!string.IsNullOrWhiteSpace(includePropeties))
            {
                foreach (var includeProperty in includePropeties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            var entities = await query.ToListAsync();

            return entities;
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter, string includePropeties = null)
        {
            IQueryable<T> query = _dbSet;

            if (!string.IsNullOrWhiteSpace(includePropeties))
            {
                foreach (var includeProperty in includePropeties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            var entities = await query.FirstOrDefaultAsync(filter);

            return entities;
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
