using System;
using System.Collections.Generic;
using BookStore.DAL.Models;

namespace BookStore.DAL.Repository.Interface
{
    public interface IAuthorRepository: IGenericRepository<Author>
    {
        new void Update(Guid id, Author author);
    }
}