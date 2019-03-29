using System;
using Bookstorage.API.DataInterfaces;
using Bookstorage.DAL.Models;


namespace Bookstorage.BLL.BusinessImplementations
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
