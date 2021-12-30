using EFDBFirstApproach.Data;
using EFDBFirstApproach.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFDBFirstApproach.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }

        public void Add(T obj)
        {
            _dbSet.Add(obj);
        }

        public int SaveChanges()
        {
            var result = _context.SaveChanges();
            return result;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
