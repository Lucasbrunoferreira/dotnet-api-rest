using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;

namespace BookStore.DAL.Repository.Implementation
{
    public class AuthorRepository : GenericRelationalRepository<Author>, IAuthorRepository
    {
    }
}