using bookstorage.API.DataInterfaces;
using bookstorage.DAL.Databases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bookstorage.DAL.DataImplementations
{
    public class GenericRelationalRepository<T> : IGenericRepository<T> where T : class
    {
        public T GetById(Guid id)
        {
            using (var dataBase = new PGSQLContext())
            {
                return dataBase.Set<T>().Find(id);
            }
        }

        public void Delete(T entity)
        {
            using (var dataBase = new PGSQLContext())
            {
                dataBase.Set<T>().Remove(entity);
                dataBase.SaveChanges();
            }
        }

        public T Get(Guid idEntity)
        {
            using (var dataBase = new PGSQLContext())
            {
                return dataBase.Set<T>().Find(idEntity);
            }
        }

        public ICollection<T> GetAll()
        {
            using (var dataBase = new PGSQLContext())
            {
                return dataBase.Set<T>().ToList();
            }
        }

        public T Insert(T entity)
        {
            using (var dataBase = new PGSQLContext())
            {
                dataBase.Set<T>().Add(entity);
                dataBase.SaveChanges();
                return entity;
            }
        }

        public T Update(Guid id, T entity)
        {
            using (var dataBase = new PGSQLContext())
            {
                dataBase.Set<T>().Update(entity);
                dataBase.SaveChanges();
                return entity;
            }
        }
    }
}