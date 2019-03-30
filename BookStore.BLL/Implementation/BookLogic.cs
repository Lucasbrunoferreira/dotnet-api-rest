using System;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;
using BookStore.BLL.Interface;

namespace BookStore.BLL.Implementation
{
    public class BookLogic : IBookLogic
    {
        private IBookRepository _bookRepository;
        public BookLogic(IBookRepository bookRepository)
        {
           _bookRepository = bookRepository;
        }

        public Book GetBookById(Guid id)
        {
            return _bookRepository.Get(id);
        }
    }
}
