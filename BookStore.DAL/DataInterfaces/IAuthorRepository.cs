using System;
using System.Collections.Generic;
using BookStore.DAL.Models;

namespace BookStore.API.DataInterfaces
{
    public interface IAuthorRepository: IGenericRepository<Author>
    {
    }
}