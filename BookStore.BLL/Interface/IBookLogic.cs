using System;
using BookStore.DAL.Models;

namespace BookStore.BLL.Interface
{
    public interface IBookLogic
    {
        Book GetBookById(Guid id);
    }
}
