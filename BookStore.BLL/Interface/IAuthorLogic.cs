using System;
using BookStore.DAL.Models;

namespace BookStore.BLL.Interface
{
    public interface IAuthorLogic
    {
      Author CreateAuthor(Author author);
    }
}
