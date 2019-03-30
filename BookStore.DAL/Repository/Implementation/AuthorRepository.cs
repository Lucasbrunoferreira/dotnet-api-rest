using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;

namespace BookStore.DAL.Repository.Implementation
{
    public class AuthorRepository : GenericRelationalRepository<Author>, IAuthorRepository
    {
        public new void Update(Guid id, Author author)
        {
            var authorToUpdate = GetById(id);
            authorToUpdate.name = author.name;
            authorToUpdate.nationality = author.nationality;
            authorToUpdate.books = author.books;

            using (var context = new DataBaseContext())
            {
                context.Update(authorToUpdate);
                context.SaveChanges();
            }
        }
    }
}