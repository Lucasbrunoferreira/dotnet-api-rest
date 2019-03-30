using BookStore.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.DAL.Repository.Implementation
{
    public class GenericRelationalRepository<T> : IGenericRepository<T> where T : class
    {
        public T GetById(Guid id)
        {
            using (var dataBase = new DataBaseContext())
            {
                return dataBase.Set<T>().Find(id);
            }
        }

        public void Delete(T registry)
        {
            using (var dataBase = new DataBaseContext())
            {
                dataBase.Set<T>().Remove(registry);
                dataBase.SaveChanges();
            }
        }

        public T Get(Guid id)
        {
            using (var dataBase = new DataBaseContext())
            {
                return dataBase.Set<T>().Find(id);
            }
        }

        public ICollection<T> GetAll()
        {
            using (var dataBase = new DataBaseContext())
            {
                return dataBase.Set<T>().ToList();
            }
        }

        public T Insert(T registry)
        {
            using (var dataBase = new DataBaseContext())
            {
                dataBase.Set<T>().Add(registry);
                dataBase.SaveChanges();
                return registry;
            }
        }

        public T Update(Guid id, T registry)
        {
            using (var dataBase = new DataBaseContext())
            {
                dataBase.Set<T>().Update(registry);
                dataBase.SaveChanges();
                return registry;
            }
        }
    }
}