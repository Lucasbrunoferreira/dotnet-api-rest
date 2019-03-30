using System;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;
using BookStore.BLL.Interface;

namespace BookStore.BLL.Implementation
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
