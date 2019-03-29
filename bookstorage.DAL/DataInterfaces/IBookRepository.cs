using System;
using System.Collections.Generic;
using bookstorage.DAL.Models;

namespace bookstorage.API.DataInterfaces
{
    public interface IBookRepository: IGenericRepository<Book>
    {
    }
}