using System;
using System.Collections.Generic;
using BookStore.DAL.Models;

namespace BookStore.BLL.Interface
{
    public interface IAuthorLogic
    {
      Author CreateAuthor(Author author);
      Author GetAuthorById(Guid id);
      ICollection<Author> GettAllAuthor();
      void DeleteAuthor(Guid id);
      void UpdateAuthor(Guid id, Author author);
    }
}
