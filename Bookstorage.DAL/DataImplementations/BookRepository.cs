using System;
using System.Collections.Generic;
using System.Linq;
using Bookstorage.API.DataInterfaces;
using Bookstorage.DAL.Models;

namespace Bookstorage.DAL.DataImplementations
{
    public class BookRepository : GenericRelationalRepository<Book>, IBookRepository
    {
    }
}