using System;

namespace EFDBFirstApproach.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T obj);

        int SaveChanges();
    }
}
