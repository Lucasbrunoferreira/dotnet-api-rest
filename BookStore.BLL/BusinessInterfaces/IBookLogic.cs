using System;
using BookStore.DAL.Models;

namespace BookStore.BLL.BusinessImplementations
{
    public interface IBookLogic
    {
        Book GetBookById(Guid id);
    }
}
