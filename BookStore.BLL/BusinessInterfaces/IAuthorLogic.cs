using System;
using BookStore.DAL.Models;

namespace BookStore.BLL.BusinessImplementations
{
    public interface IAuthorLogic
    {
      Author CreateAuthor(Author author);
    }
}
