using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.API.DataInterfaces;
using BookStore.DAL.Models;

namespace BookStore.DAL.DataImplementations
{
    public class AuthorRepository : GenericRelationalRepository<Author>, IAuthorRepository
    {
    }
}