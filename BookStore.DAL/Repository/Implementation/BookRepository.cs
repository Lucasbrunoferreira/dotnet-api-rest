using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;

namespace BookStore.DAL.Repository.Implementation
{
    public class BookRepository : GenericRelationalRepository<Book>, IBookRepository
    {
        public new void Update(Guid id, Book book)
        {
            var bookToUpdate = GetById(id);
            bookToUpdate.name = book.name;
            bookToUpdate.price = book.price;
            bookToUpdate.genre = book.genre;
            bookToUpdate.author = book.author;

            using (var context = new DataBaseContext())
            {
                context.Update(bookToUpdate);
                context.SaveChanges();
            }
        }
    }
}