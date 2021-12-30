using EFDBFirstApproach.Data;
using EFDBFirstApproach.Entities;
using EFDBFirstApproach.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFDBFirstApproach.Implementations
{
    public class StudentRepository : Repository<Students>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

        //protected readonly ApplicationDbContext _context;
        //protected readonly DbSet<Students> _dbSet;

        //public StudentRepository(ApplicationDbContext dbContext)
        //{
        //    _context = dbContext;
        //    _dbSet = _context.Set<Students>();
        //}

        //public void Add(Students obj)
        //{
        //    _dbSet.Add(obj);
        //}

        //public int SaveChanges()
        //{
        //    return _context.SaveChanges();
        //}
    }
}
