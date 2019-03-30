using System;
using System.Collections.Generic;

namespace BookStore.DAL.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T Insert(T entity);
        T Update(Guid id, T entity);
        void Delete(T entity);
        T Get(Guid idEntity);
        T GetById(Guid id);
        ICollection<T> GetAll();
    }
}