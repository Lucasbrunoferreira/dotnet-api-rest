using System;
using BookStore.DAL.Repository.Interface;
using BookStore.DAL.Models;
using BookStore.BLL.Interface;
using System.Collections.Generic;

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

        public Author GetAuthorById(Guid id)
        {
            return _authorRepository.GetById(id);
        }

        public ICollection<Author> GettAllAuthor()
        {
            return _authorRepository.GetAll();
        }

        public void DeleteAuthor(Guid id)
        {
            var author = this.GetAuthorById(id);
            if (author == null)
            {
                throw new Exception("User does not exist");
            }
           _authorRepository.Delete(author);
        }

        public void UpdateAuthor(Guid id, Author author)
        {
            _authorRepository.Update(id, author);
        }
    }
}
