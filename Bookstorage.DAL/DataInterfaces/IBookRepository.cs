using System;
using System.Collections.Generic;
using Bookstorage.DAL.Models;

namespace Bookstorage.API.DataInterfaces
{
    public interface IBookRepository: IGenericRepository<Book>
    {
    }
}