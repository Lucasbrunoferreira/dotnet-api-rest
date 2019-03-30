using System;
using BookStore.API.DataInterfaces;
using BookStore.DAL.Models;


namespace BookStore.BLL.BusinessImplementations
{
    public class AuthorLogic : IAuthorLogic
    {
        private IAuthorRepository _authorRepository;
        public AuthorLogic(IAuthorRepository authorRepository)
        {
           _authorRepository = authorRepository;
        }

        public Author CreateAuthor(Author author)
        {
            return _authorRepository.Insert(author);
        }
    }
}
