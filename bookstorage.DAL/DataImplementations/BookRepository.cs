using System;
using System.Collections.Generic;
using System.Linq;
using bookstorage.API.DataInterfaces;
using bookstorage.DAL.Models;

namespace bookstorage.DAL.DataImplementations
{
    public class BookRepository : GenericRelationalRepository<Book>, IBookRepository
    {
    }
}