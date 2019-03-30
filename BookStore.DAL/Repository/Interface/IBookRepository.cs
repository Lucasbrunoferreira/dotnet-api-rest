using System;
using System.Collections.Generic;
using BookStore.DAL.Models;

namespace BookStore.DAL.Repository.Interface
{
    public interface IBookRepository: IGenericRepository<Book>
    {
    }
}