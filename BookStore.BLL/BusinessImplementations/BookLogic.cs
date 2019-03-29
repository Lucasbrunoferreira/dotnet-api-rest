using System;
using BookStore.API.DataInterfaces;
using BookStore.DAL.Models;


namespace BookStore.BLL.BusinessImplementations
{
    public class BookLogic : IBookLogic
    {
        private IBookRepository _bookRepository;
        public BookLogic(IBookRepository bookRepository)
        {
           _bookRepository = bookRepository;
        }

        public Book SAHdsdhf(Guid id)
        {
            return _bookRepository.Get(id);
        }
    }
}
