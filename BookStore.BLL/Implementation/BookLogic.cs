using System;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;
using BookStore.BLL.Interface;
using System.Collections.Generic;

namespace BookStore.BLL.Implementation
{
    public class BookLogic : IBookLogic
    {
        private IBookRepository _bookRepository;
        public BookLogic(IBookRepository bookRepository)
        {
           _bookRepository = bookRepository;
        }

        public Book CreateBook(Book book)
        {
            return _bookRepository.Insert(book);
        }

        public ICollection<Book> GettAllBook()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBookById(Guid id)
        {
            return _bookRepository.GetById(id);
        }

        public void UpdateBook(Guid id, Book book)
        {
            _bookRepository.Update(id, book);
        }

        public void DeleteBook(Guid id)
        {
            var book = this.GetBookById(id);
            if (book == null)
            {
                throw new Exception("Book does not exist");
            }
           _bookRepository.Delete(book);
        }
    }
}
