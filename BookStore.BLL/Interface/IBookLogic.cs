using System;
using System.Collections.Generic;
using BookStore.DAL.Models;

namespace BookStore.BLL.Interface
{
    public interface IBookLogic
    {
        Book CreateBook(Book book);
        ICollection<Book> GettAllBook();
        Book GetBookById(Guid id);
        void UpdateBook(Guid id, Book book);
        void DeleteBook(Guid id);
    }
}
