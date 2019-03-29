using System;
using bookstorage.API.DataInterfaces;
using bookstorage.DAL.Models;


namespace bookstorage.BLL.BusinessImplementations
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
